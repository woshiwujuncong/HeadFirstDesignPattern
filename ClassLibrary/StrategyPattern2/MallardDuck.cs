using StrategyPattern2.Interfaces;

namespace StrategyPattern2
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck !");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying ~");
        }

        public void Quack()
        {
            Console.WriteLine("I'm quacking ~");
        }
    }
}
