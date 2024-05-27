using StrategyPattern3.Fly;
using StrategyPattern3.Quack;

namespace StrategyPattern3
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformSwim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
    }
}
