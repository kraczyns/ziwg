using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Employee
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Zespół")]
        public int TeamID { get; set; }

        public int EmployeeID { get; set; }

    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
