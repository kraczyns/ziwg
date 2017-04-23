using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Employee : Person
    {
        public Employee(string n, string s, string e, int team, int id) : base(n, s, e)
        {
            TeamID = team;
            EmployeeID = id;
        }

        public int TeamID { get; set; }
        public int EmployeeID { get; set; }

    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
