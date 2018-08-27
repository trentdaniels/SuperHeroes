namespace SuperHeroesProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using SuperHeroesProject.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperHeroesProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SuperHeroesProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.SuperHero.AddOrUpdate(hero => hero.HeroId,
                new SuperHero()
                {
                    HeroId = 1,
                    Name = "The Flash",
                    AlterEgo = "Barry Allen",
                    PrimaryAbility = "Super Speed",
                    SecondaryAbility = "Increased Durability",
                    CatchPhrase = "I'm the fastest man alive"
                },
                new SuperHero()
                {
                    HeroId = 2,
                    Name = "Jimmy Neutron",
                    AlterEgo = "James Isaac Newtron",
                    PrimaryAbility = "Super Intellect",
                    SecondaryAbility = "Large Head",
                    CatchPhrase = "Gotta Blast!"
                },
                new SuperHero()
                {
                    HeroId = 3,
                    Name = "The Quickster",
                    AlterEgo = "Spongebob Squarepants",
                    PrimaryAbility = "Super Speed",
                    SecondaryAbility = "Extra Spongey",
                    CatchPhrase = "Wanna see me run to that mountain and back? Wanna see me do it again?"
                },
                new SuperHero()
                {
                    HeroId = 4,
                    Name = "Captain Magma",
                    AlterEgo = "Squidward Tentacles",
                    PrimaryAbility = "Cranium Magma Release",
                    SecondaryAbility = "Terrible Clarinet Playing",
                    CatchPhrase = "Krakatoa!"
                },
                new SuperHero()
                {
                    HeroId = 5,
                    Name = "The Elastic Waistband",
                    AlterEgo = "Patrick Star",
                    PrimaryAbility = "Super Stretchiness",
                    SecondaryAbility = "Stupidity",
                    CatchPhrase = "Is Mayonnaise an instrument?"
                });

        }
    }
}
