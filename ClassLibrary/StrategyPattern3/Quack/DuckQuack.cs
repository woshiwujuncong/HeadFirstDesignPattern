namespace StrategyPattern3.Quack
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack ~");
        }
    }
}
