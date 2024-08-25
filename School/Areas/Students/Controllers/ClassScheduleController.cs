using System.Web.Mvc;

namespace School.Areas.Students.Controllers
{
    public class ClassScheduleController : Controller
    {
        // GET: Students/ClassSchedule
        public ActionResult Index()
        {
            return View();
        }

        // GET: Students/ClassSchedule/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Students/ClassSchedule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/ClassSchedule/Create
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

        // GET: Students/ClassSchedule/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/ClassSchedule/Edit/5
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

        // GET: Students/ClassSchedule/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/ClassSchedule/Delete/5
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
