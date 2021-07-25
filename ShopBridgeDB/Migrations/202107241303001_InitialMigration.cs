namespace ShopBridgeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryID = c.Int(nullable: false, identity: true),
                        InventoryName = c.String(),
                        InventoryDesc = c.String(),
                        price = c.Single(nullable: false),
                        InventoryType = c.String(),
                    })
                .PrimaryKey(t => t.InventoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventories");
        }
    }
}
