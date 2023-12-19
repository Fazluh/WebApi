namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductModels",
                c => new
                    {
                        ProdID = c.Int(nullable: false, identity: true),
                        ProdName = c.String(),
                        ProdPrice = c.Int(nullable: false),
                        QTY = c.Int(nullable: false),
                        ProdDesc = c.String(),
                        Size = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductModels");
        }
    }
}
