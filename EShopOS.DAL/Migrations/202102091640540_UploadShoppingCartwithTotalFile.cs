namespace EShopOS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadShoppingCartwithTotalFile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCarts", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCarts", "Total");
        }
    }
}
