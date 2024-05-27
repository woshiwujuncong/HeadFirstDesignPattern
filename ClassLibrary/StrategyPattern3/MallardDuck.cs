using StrategyPattern3.Fly;
using StrategyPattern3.Quack;

namespace StrategyPattern3
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new DuckQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck !");
        }
    }
}
