namespace Exercise12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhatIsGoingOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "Leader", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activities", "Leader");
        }
    }
}
