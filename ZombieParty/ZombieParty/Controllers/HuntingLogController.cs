using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZombieParty.Controllers
{
    public class HuntingLogController : Controller
    {
        // GET: HuntingLogController
        public ActionResult Index()
        {

            return View();
        }

        // GET: HuntingLogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HuntingLogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HuntingLogController/Create
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

        // GET: HuntingLogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HuntingLogController/Edit/5
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

        // GET: HuntingLogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HuntingLogController/Delete/5
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
