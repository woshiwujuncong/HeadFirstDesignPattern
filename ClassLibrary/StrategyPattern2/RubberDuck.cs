using StrategyPattern2.Interfaces;

namespace StrategyPattern2
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck !");
        }

        public void Quack()
        {
            Console.WriteLine("I'm quacking ~");
        }
    }
}
