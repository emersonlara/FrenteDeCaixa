namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoFormaDePagamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormaDePagamentoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FormaDePagamentoes");
        }
    }
}
