namespace Exercise12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ActivityId);
            
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        VacationId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VacationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vacations");
            DropTable("dbo.Activities");
        }
    }
}
