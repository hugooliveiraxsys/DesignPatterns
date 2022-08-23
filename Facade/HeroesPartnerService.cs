using System;
using System.Collections.Generic;

namespace Facade
{
    public static class HeroePartnerService
    {
        public static string CreatePartnerHeroName()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            List<string> heroNames = new List<string>()
            {
                "Roubin",
                "Ugo Loso",
                "Guilon Goso",
                "Zé Oliveija",
                "Zé Varize"
            };

            int index = random.Next(heroNames.Count);

            return heroNames[index];
        }
    }
}