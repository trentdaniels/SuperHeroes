using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperHeroesProject.Models;
using System.Web.Mvc;
using System.Data.Entity;

namespace SuperHeroesProject.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        public ActionResult SuperHeroes()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.SuperHero);
        }
        public ActionResult EditHero(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var selectedHero = db.SuperHero.Find(id);
            return View(selectedHero);
        }
        [HttpPost]
        public ActionResult EditHero( SuperHero hero)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Entry(hero).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("SuperHeroes");
            
        }

        public ActionResult DeleteHero(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var selectedHero = db.SuperHero.Find(id);
            return View(selectedHero);
        }
        public ActionResult HeroDetails(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var selectedHero = db.SuperHero.Find(id);
            return View(selectedHero);
        }
        public ActionResult CreateHero()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateHero(SuperHero hero)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.SuperHero.Add(hero);
            db.SaveChanges();
            return RedirectToAction("SuperHeroes");
        }
        [HttpPost]
        public ActionResult DeleteHero(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var selectedHero = db.SuperHero.Find(id);
            db.SuperHero.Remove(selectedHero);
            db.SaveChanges();
            return RedirectToAction("SuperHeroes");
        }
    }
}