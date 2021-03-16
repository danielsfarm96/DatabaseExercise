namespace Exercise12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VacationActivities",
                c => new
                    {
                        Vacation_VacationId = c.Int(nullable: false),
                        Activity_ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vacation_VacationId, t.Activity_ActivityId })
                .ForeignKey("dbo.Vacations", t => t.Vacation_VacationId, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_ActivityId, cascadeDelete: true)
                .Index(t => t.Vacation_VacationId)
                .Index(t => t.Activity_ActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VacationActivities", "Activity_ActivityId", "dbo.Activities");
            DropForeignKey("dbo.VacationActivities", "Vacation_VacationId", "dbo.Vacations");
            DropIndex("dbo.VacationActivities", new[] { "Activity_ActivityId" });
            DropIndex("dbo.VacationActivities", new[] { "Vacation_VacationId" });
            DropTable("dbo.VacationActivities");
        }
    }
}
