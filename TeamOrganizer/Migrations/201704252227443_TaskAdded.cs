namespace TeamOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskModel",
                c => new
                    {
                        TaskModelID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TaskModelID);
            
            AddColumn("dbo.Employee", "TaskModel_TaskModelID", c => c.Int());
            AddColumn("dbo.Manager", "TaskModel_TaskModelID", c => c.Int());
            CreateIndex("dbo.Employee", "TaskModel_TaskModelID");
            CreateIndex("dbo.Manager", "TaskModel_TaskModelID");
            AddForeignKey("dbo.Employee", "TaskModel_TaskModelID", "dbo.TaskModel", "TaskModelID");
            AddForeignKey("dbo.Manager", "TaskModel_TaskModelID", "dbo.TaskModel", "TaskModelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manager", "TaskModel_TaskModelID", "dbo.TaskModel");
            DropForeignKey("dbo.Employee", "TaskModel_TaskModelID", "dbo.TaskModel");
            DropIndex("dbo.Manager", new[] { "TaskModel_TaskModelID" });
            DropIndex("dbo.Employee", new[] { "TaskModel_TaskModelID" });
            DropColumn("dbo.Manager", "TaskModel_TaskModelID");
            DropColumn("dbo.Employee", "TaskModel_TaskModelID");
            DropTable("dbo.TaskModel");
        }
    }
}
