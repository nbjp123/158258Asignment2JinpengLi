namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.bkmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.bkmDbContext context)
        {

            new baokem { Name = "Bulbasaur", ID = 1 ,Type1 = "Grass" ,Type2 = "Poison",};
            new baokem { Name = "Ivysaur", ID = 2, Type1 = "Grass", Type2 = "Poison", };
            new baokem { Name = "Venusaur", ID = 3, Type1 = "Grass", Type2 = "Poison", };
            

        }
    }
}
