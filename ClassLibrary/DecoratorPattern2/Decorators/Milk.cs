using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            Description = "Milk";
            Cost = 1;
        }
    }
}
