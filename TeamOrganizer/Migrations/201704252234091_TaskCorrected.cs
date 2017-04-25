namespace TeamOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskCorrected : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskModel", "status", c => c.Int(nullable: false));
            AddColumn("dbo.TaskModel", "description", c => c.String());
            AddColumn("dbo.TaskModel", "points", c => c.Int(nullable: false));
            AddColumn("dbo.TaskModel", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskModel", "endDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.TaskModel", "TeamID", c => c.Int(nullable: false));
            AddColumn("dbo.TaskModel", "Owner_EmployeeID", c => c.Int());
            CreateIndex("dbo.TaskModel", "Owner_EmployeeID");
            AddForeignKey("dbo.TaskModel", "Owner_EmployeeID", "dbo.Employee", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskModel", "Owner_EmployeeID", "dbo.Employee");
            DropIndex("dbo.TaskModel", new[] { "Owner_EmployeeID" });
            DropColumn("dbo.TaskModel", "Owner_EmployeeID");
            DropColumn("dbo.TaskModel", "TeamID");
            DropColumn("dbo.TaskModel", "endDate");
            DropColumn("dbo.TaskModel", "startDate");
            DropColumn("dbo.TaskModel", "points");
            DropColumn("dbo.TaskModel", "description");
            DropColumn("dbo.TaskModel", "status");
        }
    }
}
