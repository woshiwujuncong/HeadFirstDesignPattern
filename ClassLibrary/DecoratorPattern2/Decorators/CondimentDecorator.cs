using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; }

        protected double Cost { get; set; }

        protected string Description { get; set; }

        protected CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + $" with {Description}";
        }

        public override double GetCost()
        {
            return Beverage.GetCost() + Cost;
        }
    }
}
