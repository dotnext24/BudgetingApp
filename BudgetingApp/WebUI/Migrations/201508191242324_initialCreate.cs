namespace WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountLevels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descriptionn = c.String(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Accounts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberID = c.String(nullable: false, maxLength: 128),
                        AccountLabelID = c.Int(nullable: false),
                        MinimumThreshold = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentID = c.Int(nullable: false),
                        AccountName = c.String(),
                        IsPrimary = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AccountLevels", t => t.AccountLabelID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.AccountLabelID)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        JoiningDate = c.DateTime(),
                        IsActive = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PaidBy = c.String(nullable: false),
                        PromocodeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PromoCodes", t => t.PromocodeID, cascadeDelete: true)
                .Index(t => t.PromocodeID);
            
            CreateTable(
                "dbo.PromoCodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsUsed = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "PromocodeID", "dbo.PromoCodes");
            DropForeignKey("dbo.Accounts", "MemberID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Accounts", "AccountLabelID", "dbo.AccountLevels");
            DropIndex("dbo.Payments", new[] { "PromocodeID" });
            DropIndex("dbo.Accounts", new[] { "MemberID" });
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Accounts", new[] { "AccountLabelID" });
            DropTable("dbo.PromoCodes");
            DropTable("dbo.Payments");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountLevels");
        }
    }
}
