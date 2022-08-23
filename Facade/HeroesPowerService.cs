using System;

namespace Facade
{
    //Static, faz parte do exemplo
    public static class HeroesPowerService
    {
        public static int CreateHeroPower()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            int power = random.Next(21000);

            return power;
        }
    }
}
