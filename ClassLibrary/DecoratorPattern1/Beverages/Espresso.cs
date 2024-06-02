namespace DecoratorPattern1.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 10 + base.Cost();
        }
    }
}
