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
        // GET: Task
        public ActionResult Index()
        {

            try
            {
                return RedirectToAction("Dashboard");
            }
            catch
            {
                return View();
            }
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
        public ActionResult Create(FormCollection collection)
        {
            Random rnd = new Random();
            TaskModel zadanko = new TaskModel();
            zadanko.SetPoints(Convert.ToInt32(collection["points"]));
            zadanko.SetStartDate(Convert.ToString(collection["startdate"]),
                                 Convert.ToString(collection["duration"])
                                 );
            zadanko.SetDescription(Convert.ToString(collection["description"]));
            zadanko.SetId(rnd.Next());
            zadanko.SetStatus("Nowe");

            ViewBag.punkty = Convert.ToString(zadanko.GetPoints());
            ViewBag.koniec = zadanko.GetEndDate();
            ViewBag.opis = zadanko.GetDescription();
            ViewBag.status = zadanko.GetStatus();
            ViewBag.datastart = zadanko.GetStartDate();
            ViewBag.id = Convert.ToString(zadanko.GetId());


            return View();
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
