namespace DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        protected string Description { get; set; } = "";

        protected double Cost { get; set; }

        public virtual string GetDescription()
        {
            return Description;
        }

        public virtual double GetCost()
        {
            return Cost;
        }
    }
}
