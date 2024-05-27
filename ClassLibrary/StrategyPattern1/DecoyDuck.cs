namespace StrategyPattern1
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck !");
        }

        public override void Fly()
        {
            // Do nothing !
        }

        public override void Quack()
        {
            // Do nothing !
        }
    }
}
