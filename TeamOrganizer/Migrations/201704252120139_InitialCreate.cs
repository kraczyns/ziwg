namespace TeamOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        TeamID = c.Int(nullable: false),
                        Employee_EmployeeID = c.Int(),
                        Manager_ManagerID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employee", t => t.Employee_EmployeeID)
                .ForeignKey("dbo.Manager", t => t.Manager_ManagerID)
                .Index(t => t.Employee_EmployeeID)
                .Index(t => t.Manager_ManagerID);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        ManagerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ManagerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Manager_ManagerID", "dbo.Manager");
            DropForeignKey("dbo.Employee", "Employee_EmployeeID", "dbo.Employee");
            DropIndex("dbo.Employee", new[] { "Manager_ManagerID" });
            DropIndex("dbo.Employee", new[] { "Employee_EmployeeID" });
            DropTable("dbo.Manager");
            DropTable("dbo.Employee");
        }
    }
}
