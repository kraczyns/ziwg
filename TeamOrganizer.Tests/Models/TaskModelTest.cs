using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamOrganizer;
using TeamOrganizer.Models;

namespace TeamOrganizer.Tests.Models
{
    [TestClass]
    public class TaskModelTest
    {
        Random rnd = new Random();
        
        [TestMethod]
        public void TaskId()
        {
            int id = rnd.Next();
            TaskModel zadanie = new TaskModel();
            zadanie.SetId(id);
            Assert.AreEqual(id, zadanie.GetId());
        }

        [TestMethod]
        public void Status()
        {
            TaskModel zadanie = new TaskModel();
            foreach (Statuses sta in Enum.GetValues(typeof(Statuses)))
            {
                string status = sta.ToString();
                Assert.IsTrue(zadanie.SetStatus(status));
                Assert.AreEqual(status, zadanie.GetStatus());
            }
        }

        [TestMethod]
        public void Description()
        {
            TaskModel zadanie = new TaskModel();
            string desc = "Ala ma kota, kot ma ale";
            zadanie.SetDescription(desc);
            Assert.AreEqual(desc,zadanie.GetDescription());
        }

        [TestMethod]
        public void Points()
        {
            TaskModel zadanie = new TaskModel();
            int punkty = -4;

            try
            {
                zadanie.SetPoints(punkty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Assert.IsInstanceOfType(e,typeof(ArgumentException));
                //throw;
            }
            Assert.AreNotEqual(zadanie.GetPoints(),punkty);

            punkty = 10;
            try
            {
                zadanie.SetPoints(punkty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Assert.AreEqual(zadanie.GetPoints(),punkty);
        }
    }
}
