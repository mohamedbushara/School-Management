﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Areas.ManagementSchool.Controllers
{
    public class ManagementSchoolController : Controller
    {
        // GET: ManagementSchool/Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: ManagementSchool/Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManagementSchool/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagementSchool/Admin/Create
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

        // GET: ManagementSchool/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManagementSchool/Admin/Edit/5
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

        // GET: ManagementSchool/Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManagementSchool/Admin/Delete/5
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
