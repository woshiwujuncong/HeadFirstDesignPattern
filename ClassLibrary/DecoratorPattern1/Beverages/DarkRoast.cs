namespace DecoratorPattern1.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Most Excellent Dark Roast";
        }

        public override double Cost()
        {
            return 15 + base.Cost();
        }
    }
}
