using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Person
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public Person(string n, string s, string e)
        {
            Name = n;
            Surname = s;
            Email = e;
        }
    }
}
