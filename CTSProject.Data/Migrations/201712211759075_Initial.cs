namespace CTSProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Rating", c => c.Double(nullable: false));
            DropColumn("dbo.MainPhotoes", "Height");
            DropColumn("dbo.MainPhotoes", "Width");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MainPhotoes", "Width", c => c.Int(nullable: false));
            AddColumn("dbo.MainPhotoes", "Height", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Count");
        }
    }
}
