using DecoratorPattern.Beverages;

namespace DecoratorPattern.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            Description = "Whip";
            Cost = 0.5;
        }
    }
}
