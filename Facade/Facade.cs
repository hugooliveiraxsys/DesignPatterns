namespace Facade
{
    public class Facade
    {
        public static Hero CreateHero()
        {
            Hero hero = new Hero();

            hero.Name = HeroesNameService.CreateHeroName();
            hero.Partner = HeroePartnerService.CreatePartnerHeroName();
            hero.Power = HeroesPowerService.CreateHeroPower();

            return hero;
        }
    }
}