using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Manager : Person
    {
        public int ManagerID { get; set; }

        public Manager(string n, string s, string e, int id) : base(n, s, e)
        {
            ManagerID = id;
        }
    }

    public class ManagerDbContext : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
    }
}
