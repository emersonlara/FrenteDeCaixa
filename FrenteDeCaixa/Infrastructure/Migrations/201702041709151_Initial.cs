namespace FrenteDeCaixa.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        Tipo = c.String(),
                        Excluido = c.Boolean(nullable: false),
                        DocumentoDeIdentificacao_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentoDeIdentificacaoDomains", t => t.DocumentoDeIdentificacao_Id)
                .Index(t => t.DocumentoDeIdentificacao_Id);
            
            CreateTable(
                "dbo.DocumentoDeIdentificacaoDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Documento = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormaDePagamentoDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemVendaDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VendaId = c.Guid(),
                        ProdutoId = c.Guid(),
                        Quantidade = c.Int(nullable: false),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProdutoDomains", t => t.ProdutoId)
                .ForeignKey("dbo.VendaDomains", t => t.VendaId)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.ProdutoDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        FornecedorId = c.Guid(),
                        Quantidade = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClienteDomains", t => t.FornecedorId)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.VendaDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UsuarioId = c.Guid(),
                        ClienteId = c.Guid(),
                        FormaDePagamentoId = c.Guid(),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClienteDomains", t => t.ClienteId)
                .ForeignKey("dbo.FormaDePagamentoDomains", t => t.FormaDePagamentoId)
                .ForeignKey("dbo.UsuarioDomains", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.ClienteId)
                .Index(t => t.FormaDePagamentoId);
            
            CreateTable(
                "dbo.UsuarioDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        PerfilId = c.Guid(),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PerfilDeUsuarioDomains", t => t.PerfilId)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.PerfilDeUsuarioDomains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendaDomains", "VendaId", "dbo.VendaDomains");
            DropForeignKey("dbo.VendaDomains", "UsuarioId", "dbo.UsuarioDomains");
            DropForeignKey("dbo.UsuarioDomains", "PerfilId", "dbo.PerfilDeUsuarioDomains");
            DropForeignKey("dbo.VendaDomains", "FormaDePagamentoId", "dbo.FormaDePagamentoDomains");
            DropForeignKey("dbo.VendaDomains", "ClienteId", "dbo.ClienteDomains");
            DropForeignKey("dbo.ItemVendaDomains", "ProdutoId", "dbo.ProdutoDomains");
            DropForeignKey("dbo.ProdutoDomains", "FornecedorId", "dbo.ClienteDomains");
            DropForeignKey("dbo.ClienteDomains", "DocumentoDeIdentificacao_Id", "dbo.DocumentoDeIdentificacaoDomains");
            DropIndex("dbo.UsuarioDomains", new[] { "PerfilId" });
            DropIndex("dbo.VendaDomains", new[] { "FormaDePagamentoId" });
            DropIndex("dbo.VendaDomains", new[] { "ClienteId" });
            DropIndex("dbo.VendaDomains", new[] { "UsuarioId" });
            DropIndex("dbo.ProdutoDomains", new[] { "FornecedorId" });
            DropIndex("dbo.ItemVendaDomains", new[] { "ProdutoId" });
            DropIndex("dbo.ItemVendaDomains", new[] { "VendaId" });
            DropIndex("dbo.ClienteDomains", new[] { "DocumentoDeIdentificacao_Id" });
            DropTable("dbo.PerfilDeUsuarioDomains");
            DropTable("dbo.UsuarioDomains");
            DropTable("dbo.VendaDomains");
            DropTable("dbo.ProdutoDomains");
            DropTable("dbo.ItemVendaDomains");
            DropTable("dbo.FormaDePagamentoDomains");
            DropTable("dbo.DocumentoDeIdentificacaoDomains");
            DropTable("dbo.ClienteDomains");
        }
    }
}
