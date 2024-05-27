using StrategyPattern2.Interfaces;

namespace StrategyPattern2
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck !");
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
