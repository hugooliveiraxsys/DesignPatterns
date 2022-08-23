namespace Builder
{
    public class Hero
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Partner { get; set; }
        public string Cape { get; set; }
        public string Ring { get; set; }
        public bool CanFly { get; set; }

        public Hero BuildWithNoCape()
        {
            Cape = "Sem capa";
            return this;
        }

        public Hero BuildWithNoRing()
        {
            Ring = "Sem anel";
            return this;
        }

        public Hero BuildWithNoPower()
        {
            Power = 0;
            return this;
        }

        public Hero BuildWithUnknowPower()
        {
            Name = null;
            return this;
        }
        public Hero BuildBátima()
        {
            Name = "Bátima";
            Power = 0;
            Partner = "Roubin";
            Cape = "Black Cape";
            CanFly = false;
            Ring = null;
            return this;
        }
        public Hero BuildSuperOmi()
        {
            Name = "SuperOmi";
            Power = 10000;
            Partner = null;
            Cape = "Red Cape";
            CanFly = true;
            Ring = null;
            return this;
        }
    }
}
