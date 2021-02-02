namespace EShopOS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopUpdateOrder_Id : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingCarts", "Order_Id", "dbo.Orders");
            DropIndex("dbo.ShoppingCarts", new[] { "Order_Id" });
            DropColumn("dbo.ShoppingCarts", "Order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShoppingCarts", "Order_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ShoppingCarts", "Order_Id");
            AddForeignKey("dbo.ShoppingCarts", "Order_Id", "dbo.Orders", "Id", cascadeDelete: true);
        }
    }
}
