using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            Description = "Soy";
            Cost = 2;
        }
    }
}
