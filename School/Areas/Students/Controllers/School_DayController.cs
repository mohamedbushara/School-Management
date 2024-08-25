using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Areas.Students.Controllers
{
    public class School_DayController : Controller
    {
        // GET: Students/School_Day
        public ActionResult Index()
        {
            return View();
        }

        // GET: Students/School_Day/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Students/School_Day/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/School_Day/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/School_Day/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/School_Day/Edit/5
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

        // GET: Students/School_Day/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/School_Day/Delete/5
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
    }
}
