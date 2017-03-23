using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
