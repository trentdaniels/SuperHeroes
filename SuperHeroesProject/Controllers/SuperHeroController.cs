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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SuperHeroes()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.SuperHero);
        }
        public ActionResult EditHero(int heroId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var selectedHero = db.SuperHero.SingleOrDefault(hero.HeroId == heroId)
            return View();
        }

        public ActionResult DeleteHero()
        {
            return View();
        }
        public ActionResult HeroDetails()
        {
            return View();
        }
        public ActionResult CreateHero()
        {
            return View();
        }
    }
}