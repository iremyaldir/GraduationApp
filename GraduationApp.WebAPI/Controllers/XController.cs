using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    public class XController : Controller
    {
        // GET: XController
        public ActionResult Index()
        {
            return View();
        }

        // GET: XController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: XController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: XController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: XController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: XController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: XController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: XController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
