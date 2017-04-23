using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOrganizer.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Person(string n, string s, string e)
        {
            Name = n;
            Surname = s;
            Email = e;
        }
    }
}
