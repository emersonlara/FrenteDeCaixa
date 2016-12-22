namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVendas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProdutoId = c.Guid(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "PerfilID", c => c.Guid());
            AddColumn("dbo.Usuarios", "PerfilId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Clientes", "PerfilID");
            CreateIndex("dbo.Usuarios", "PerfilId");
            AddForeignKey("dbo.Clientes", "PerfilID", "dbo.PerfilDeUsuarios", "Id");
            AddForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios", "Id", cascadeDelete: true);
            DropColumn("dbo.Clientes", "Tipo");
            DropColumn("dbo.Usuarios", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Tipo", c => c.String());
            AddColumn("dbo.Clientes", "Tipo", c => c.String());
            DropForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios");
            DropForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtoes");
            DropForeignKey("dbo.Clientes", "PerfilID", "dbo.PerfilDeUsuarios");
            DropIndex("dbo.Usuarios", new[] { "PerfilId" });
            DropIndex("dbo.ItemVendas", new[] { "ProdutoId" });
            DropIndex("dbo.Clientes", new[] { "PerfilID" });
            DropColumn("dbo.Usuarios", "PerfilId");
            DropColumn("dbo.Clientes", "PerfilID");
            DropTable("dbo.Produtoes");
            DropTable("dbo.ItemVendas");
        }
    }
}
