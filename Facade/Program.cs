using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hero hero = Facade.CreateHero();
            Console.WriteLine($"Hero Name = {hero.Name}");
            Console.WriteLine($"Hero Power = {hero.Power}");
            Console.WriteLine($"Hero Parner = {hero.Partner}");

        }
    }
}
