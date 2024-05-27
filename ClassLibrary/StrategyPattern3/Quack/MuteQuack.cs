namespace StrategyPattern3.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Sorry ~ I can't quack ...");
        }
    }
}
