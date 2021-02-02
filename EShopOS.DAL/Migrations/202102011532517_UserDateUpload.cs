namespace EShopOS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDateUpload : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NameAndSurname", c => c.String());
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Province");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Province", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            DropColumn("dbo.AspNetUsers", "NameAndSurname");
        }
    }
}
