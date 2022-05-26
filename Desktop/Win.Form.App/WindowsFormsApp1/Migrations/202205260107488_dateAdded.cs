namespace WindowsFormsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "DateOfPurchase", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventories", "DateOfPurchase");
        }
    }
}
