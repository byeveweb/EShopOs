namespace EShopOS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitarRelacionSobrante : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropIndex("dbo.Products", new[] { "ShoppingCart_Id" });
            DropColumn("dbo.Products", "ShoppingCart_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ShoppingCart_Id", c => c.Int());
            CreateIndex("dbo.Products", "ShoppingCart_Id");
            AddForeignKey("dbo.Products", "ShoppingCart_Id", "dbo.ShoppingCarts", "Id");
        }
    }
}
