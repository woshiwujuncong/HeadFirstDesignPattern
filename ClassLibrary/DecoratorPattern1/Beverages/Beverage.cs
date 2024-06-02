namespace DecoratorPattern1.Beverages
{
    public abstract class Beverage
    {
        protected string Description { get; set; } = "";

        public bool Milk { get; set; }
        
        public bool Soy { get; set; }

        public bool Mocha { get; set; }

        public bool Whip { get; set; }

        public virtual double Cost()
        {
            double cost = 0;

            if (Milk)
            {
                cost += 1;
            }
            if (Soy)
            {
                cost += 1.5;
            }
            if (Mocha)
            {
                cost += 2;
            }
            if (Whip)
            {
                cost += 2.5;
            }

            return cost;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
