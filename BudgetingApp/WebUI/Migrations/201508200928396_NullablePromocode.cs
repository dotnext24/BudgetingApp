namespace WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullablePromocode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "PromocodeID", "dbo.PromoCodes");
            DropIndex("dbo.Payments", new[] { "PromocodeID" });
            AlterColumn("dbo.Payments", "PromocodeID", c => c.Int());
            CreateIndex("dbo.Payments", "PromocodeID");
            AddForeignKey("dbo.Payments", "PromocodeID", "dbo.PromoCodes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "PromocodeID", "dbo.PromoCodes");
            DropIndex("dbo.Payments", new[] { "PromocodeID" });
            AlterColumn("dbo.Payments", "PromocodeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "PromocodeID");
            AddForeignKey("dbo.Payments", "PromocodeID", "dbo.PromoCodes", "ID", cascadeDelete: true);
        }
    }
}
