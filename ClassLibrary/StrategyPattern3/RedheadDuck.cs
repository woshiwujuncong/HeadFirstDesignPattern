using StrategyPattern3.Fly;
using StrategyPattern3.Quack;

namespace StrategyPattern3
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new DuckQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck !");
        }
    }
}
