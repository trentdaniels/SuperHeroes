using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperHeroesProject.Models
{
    public class SuperHero
    {
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}