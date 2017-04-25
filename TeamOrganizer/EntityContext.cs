using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamOrganizer.Models;

namespace TeamOrganizer
{
    class EntityContext : DbContext
    {

            public EntityContext() : base("EntityContext")
            {
            }

          //  public DbSet<Task> Tasks { get; set; }
            public DbSet<Manager> Managers { get; set; }
            public DbSet<Employee> Employees { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }

    }
}
