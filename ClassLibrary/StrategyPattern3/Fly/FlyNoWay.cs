namespace StrategyPattern3.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Sorry ~ I can't fly ...");
        }
    }
}
