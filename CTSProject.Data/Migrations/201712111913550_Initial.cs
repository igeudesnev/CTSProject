namespace CTSProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductToDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Category_Id = c.Int(),
                        Cart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Carts", t => t.Cart_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Cart_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToDbs", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.ProductToDbs", "Category_Id", "dbo.Categories");
            DropIndex("dbo.ProductToDbs", new[] { "Cart_Id" });
            DropIndex("dbo.ProductToDbs", new[] { "Category_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
            DropTable("dbo.ProductToDbs");
            DropTable("dbo.Carts");
        }
    }
}
