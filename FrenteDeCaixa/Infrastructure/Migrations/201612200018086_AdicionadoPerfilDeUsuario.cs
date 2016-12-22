namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoPerfilDeUsuario : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.PerfilDeUsuarios");
        }
    }
}
