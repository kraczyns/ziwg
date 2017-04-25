using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }

    //    public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }


}
