using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroesProject.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        public ActionResult SuperHeroes()
        {
            return View();
        }
        public ActionResult EditHero()
        {
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
    }
}