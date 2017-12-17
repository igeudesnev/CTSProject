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
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Rating = c.Int(nullable: false),
                        ReviewsCount = c.Int(nullable: false),
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
                "dbo.MainPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        URL = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Opinions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                        Autor = c.String(),
                        Text = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
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
            DropForeignKey("dbo.Opinions", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.MainPhotoes", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Opinions", new[] { "Product_Id" });
            DropIndex("dbo.MainPhotoes", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Cart_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Opinions");
            DropTable("dbo.MainPhotoes");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Carts");
        }
    }
}
