using StrategyPattern3.Fly;
using StrategyPattern3.Quack;

namespace StrategyPattern3
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck !");
        }
    }
}
