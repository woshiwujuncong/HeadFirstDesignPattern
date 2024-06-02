using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            Description = "Mocha";
            Cost = 1.5;
        }
    }
}
