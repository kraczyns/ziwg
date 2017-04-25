using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamOrganizer.Models;

namespace TeamOrganizer.Controllers
{
    public class TaskController : Controller
    {
        private EntityContext db = new EntityContext();

        // GET: Task
        public ActionResult Index()
        {
                return View(db.Tasks.ToList());
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Tutaj możesz dodać nowe zadanie";
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "TaskModelID,TeamID,Employee,description,statuses,startDate,endDate,points")] TaskModel task)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard tutaj będzie :)";
            ViewBag.Title = "Widok panelu zadań";
            return View();
        }
    }
}
