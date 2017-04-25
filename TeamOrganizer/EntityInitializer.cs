using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamOrganizer.Models;

namespace TeamOrganizer
{
    class EntityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            var managers = new List<Manager>
            {
                new Manager {Name="Adam", Surname="Nowak", Email="adam@nowak.com"},
                new Manager {Name="Marek", Surname="Kowalski", Email="marek@kowalski.com"},
                new Manager {Name="Jan", Surname="Dąb", Email="jan@dab.com"}
            };
            managers.ForEach(s => context.Managers.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee {Name="Jacek", Surname="Nowak", Email="jacek@nowak.com", TeamID=1},
                new Employee {Name="Stanisław", Surname="Kowalski", Email="stanislaw@kowalski.com", TeamID=1},
                new Employee {Name="Zbigniew", Surname="Dąb", Email="zbigniew@dab.com", TeamID=1}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var tasks = new List<TaskModel>
            {
                new TaskModel { description="Zadanie1", TeamID=1, Owner=employees[0]},
                new TaskModel { description="Zadanie2", TeamID=1, Owner=employees[1]},
                new TaskModel { description="Zadanie3", TeamID=1, Owner=employees[0]},
            };
            tasks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();
        }
        }
    }

