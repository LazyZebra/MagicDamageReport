namespace MDR.Data.Sql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DamageArea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DamageEntityType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DamageEntityType", t => t.DamageEntityType_Id)
                .Index(t => t.DamageEntityType_Id);
            
            CreateTable(
                "dbo.DamageEntityType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DamageReport",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        Name = c.String(),
                        DamageEntityType_Id = c.Int(),
                        ReportingCompany_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DamageEntityType", t => t.DamageEntityType_Id)
                .ForeignKey("dbo.ReportingCompany", t => t.ReportingCompany_Id)
                .Index(t => t.DamageEntityType_Id)
                .Index(t => t.ReportingCompany_Id);
            
            CreateTable(
                "dbo.DamageReportItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DamageArea_Id = c.Int(),
                        DamageEstimatedCost_Id = c.Int(),
                        DamageSeverity_Id = c.Int(),
                        DamageReport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DamageArea", t => t.DamageArea_Id)
                .ForeignKey("dbo.DamageEstimatedCost", t => t.DamageEstimatedCost_Id)
                .ForeignKey("dbo.DamageSeverity", t => t.DamageSeverity_Id)
                .ForeignKey("dbo.DamageReport", t => t.DamageReport_Id)
                .Index(t => t.DamageArea_Id)
                .Index(t => t.DamageEstimatedCost_Id)
                .Index(t => t.DamageSeverity_Id)
                .Index(t => t.DamageReport_Id);
            
            CreateTable(
                "dbo.DamageEstimatedCost",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DamageSeverity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DamageEntityType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DamageEntityType", t => t.DamageEntityType_Id)
                .Index(t => t.DamageEntityType_Id);
            
            CreateTable(
                "dbo.ReportingCompany",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DamageReport", "ReportingCompany_Id", "dbo.ReportingCompany");
            DropForeignKey("dbo.DamageReportItem", "DamageReport_Id", "dbo.DamageReport");
            DropForeignKey("dbo.DamageReportItem", "DamageSeverity_Id", "dbo.DamageSeverity");
            DropForeignKey("dbo.DamageSeverity", "DamageEntityType_Id", "dbo.DamageEntityType");
            DropForeignKey("dbo.DamageReportItem", "DamageEstimatedCost_Id", "dbo.DamageEstimatedCost");
            DropForeignKey("dbo.DamageReportItem", "DamageArea_Id", "dbo.DamageArea");
            DropForeignKey("dbo.DamageReport", "DamageEntityType_Id", "dbo.DamageEntityType");
            DropForeignKey("dbo.DamageArea", "DamageEntityType_Id", "dbo.DamageEntityType");
            DropIndex("dbo.DamageSeverity", new[] { "DamageEntityType_Id" });
            DropIndex("dbo.DamageReportItem", new[] { "DamageReport_Id" });
            DropIndex("dbo.DamageReportItem", new[] { "DamageSeverity_Id" });
            DropIndex("dbo.DamageReportItem", new[] { "DamageEstimatedCost_Id" });
            DropIndex("dbo.DamageReportItem", new[] { "DamageArea_Id" });
            DropIndex("dbo.DamageReport", new[] { "ReportingCompany_Id" });
            DropIndex("dbo.DamageReport", new[] { "DamageEntityType_Id" });
            DropIndex("dbo.DamageArea", new[] { "DamageEntityType_Id" });
            DropTable("dbo.ReportingCompany");
            DropTable("dbo.DamageSeverity");
            DropTable("dbo.DamageEstimatedCost");
            DropTable("dbo.DamageReportItem");
            DropTable("dbo.DamageReport");
            DropTable("dbo.DamageEntityType");
            DropTable("dbo.DamageArea");
        }
    }
}
