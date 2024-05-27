using StrategyPattern3.Fly;
using StrategyPattern3.Quack;

namespace StrategyPattern3
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck !");
        }
    }
}
