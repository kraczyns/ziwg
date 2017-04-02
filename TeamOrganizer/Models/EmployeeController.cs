using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

    public class Manager : Person
    {
        public int ManagerID { get; set; }

        public Manager(string n, string s, string e, int id) : base(n, s, e)
        {
            ManagerID = id;
        }
    }

    public class EmployeeController : Controller
    {



        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
    }
}