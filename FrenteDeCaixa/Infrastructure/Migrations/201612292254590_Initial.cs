using System.Data.Entity.Migrations;

namespace FrenteDeCaixa.Infrastructure.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        CpfCnpj = c.String(),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormaDePagamentoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemVendas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VendaId = c.Guid(),
                        ProdutoId = c.Guid(),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId)
                .ForeignKey("dbo.Vendas", t => t.VendaId)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        FornecedorId = c.Guid(),
                        Quantidade = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.FornecedorId)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UsuarioId = c.Guid(),
                        ClienteId = c.Guid(),
                        FormaDePagamentoId = c.Guid(),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.FormaDePagamentoes", t => t.FormaDePagamentoId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.ClienteId)
                .Index(t => t.FormaDePagamentoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        PerfilId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PerfilDeUsuarios", t => t.PerfilId)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.PerfilDeUsuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios");
            DropForeignKey("dbo.Vendas", "FormaDePagamentoId", "dbo.FormaDePagamentoes");
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtoes");
            DropForeignKey("dbo.Produtoes", "FornecedorId", "dbo.Clientes");
            DropIndex("dbo.Usuarios", new[] { "PerfilId" });
            DropIndex("dbo.Vendas", new[] { "FormaDePagamentoId" });
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropIndex("dbo.Vendas", new[] { "UsuarioId" });
            DropIndex("dbo.Produtoes", new[] { "FornecedorId" });
            DropIndex("dbo.ItemVendas", new[] { "ProdutoId" });
            DropIndex("dbo.ItemVendas", new[] { "VendaId" });
            DropTable("dbo.PerfilDeUsuarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtoes");
            DropTable("dbo.ItemVendas");
            DropTable("dbo.FormaDePagamentoes");
            DropTable("dbo.Clientes");
        }
    }
}
