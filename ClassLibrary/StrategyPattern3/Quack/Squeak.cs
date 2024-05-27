namespace StrategyPattern3.Quack
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak squeak ~");
        }
    }
}
