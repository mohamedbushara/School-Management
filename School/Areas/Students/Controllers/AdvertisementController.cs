using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Areas.Students.Controllers
{
    public class AdvertisementController : Controller
    {
        // GET: Students/Advertisement
        public ActionResult Index()
        {
            return View();
        }

        // GET: Students/Advertisement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Students/Advertisement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Advertisement/Create
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

        // GET: Students/Advertisement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/Advertisement/Edit/5
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

        // GET: Students/Advertisement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/Advertisement/Delete/5
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
