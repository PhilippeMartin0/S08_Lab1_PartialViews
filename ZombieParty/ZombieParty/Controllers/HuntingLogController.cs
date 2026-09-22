using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.Models.Data;

namespace ZombieParty.Controllers
{
    public class HuntingLogController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }
        public HuntingLogController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }
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
        public IActionResult Upsert(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return View(new Weapon());
            }
            else
                return View(_baseDonnees.Weapons.Find(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                // Create
                if (weapon.WeaponId == 0)
                {
                    // Ajouter à la BD
                    _baseDonnees.Weapons.Add(weapon);
                    TempData["Success"] = $"{weapon.Name} weapon added";
                }
                else
                {
                    // Update
                    _baseDonnees.Weapons.Update(weapon);
                    TempData["success"] = $"{weapon.Name} weapon updated";
                }
                _baseDonnees.SaveChanges();

                return this.RedirectToAction("Index");
            }

            return this.View(weapon);
        }
    }
}
