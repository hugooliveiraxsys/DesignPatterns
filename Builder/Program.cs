using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Hero hero = new Hero();
            hero
                .BuildWithNoPower()
                .BuildWithNoRing()
                .BuildWithNoCape();

            hero.Name = "Dona maria";
            hero.Partner = "Cleber";

            Console.WriteLine($"Hero Name = {hero.Name}");
            Console.WriteLine($"Hero Power = {hero.Power}");
            Console.WriteLine($"Hero Parner = {hero.Partner}");
            Console.WriteLine($"Hero Cape = {hero.Cape}");
            Console.WriteLine($"Hero CanFly = {hero.CanFly}");

            Console.WriteLine("Fim");

        }
    }
}
