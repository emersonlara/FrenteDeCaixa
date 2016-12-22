namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "PerfilID", "dbo.PerfilDeUsuarios");
            DropForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios");
            DropIndex("dbo.Clientes", new[] { "PerfilID" });
            DropIndex("dbo.Usuarios", new[] { "PerfilId" });
            AddColumn("dbo.Clientes", "Tipo", c => c.String());
            AlterColumn("dbo.Usuarios", "PerfilId", c => c.Guid());
            CreateIndex("dbo.Usuarios", "PerfilId");
            AddForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios", "Id");
            DropColumn("dbo.Clientes", "PerfilID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "PerfilID", c => c.Guid());
            DropForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios");
            DropIndex("dbo.Usuarios", new[] { "PerfilId" });
            AlterColumn("dbo.Usuarios", "PerfilId", c => c.Guid(nullable: false));
            DropColumn("dbo.Clientes", "Tipo");
            CreateIndex("dbo.Usuarios", "PerfilId");
            CreateIndex("dbo.Clientes", "PerfilID");
            AddForeignKey("dbo.Usuarios", "PerfilId", "dbo.PerfilDeUsuarios", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Clientes", "PerfilID", "dbo.PerfilDeUsuarios", "Id");
        }
    }
}
