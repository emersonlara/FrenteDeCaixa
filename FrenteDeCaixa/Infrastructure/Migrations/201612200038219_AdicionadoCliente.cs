namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoCliente : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
