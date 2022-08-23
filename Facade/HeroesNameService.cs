using System;
using System.Collections.Generic;

namespace Facade
{
    public static class HeroesNameService
    {
        public static string CreateHeroName()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            List<string> heroNames = new List<string>()
            {
                "Bátima",
                "Fátima",
                "Super Ómi",
                "Ómiranha",
                "Porco Aranha"
            };

            int index = random.Next(heroNames.Count);

            return heroNames[index];
        }
    }
}