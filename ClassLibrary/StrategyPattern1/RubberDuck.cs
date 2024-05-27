namespace StrategyPattern1
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck !");
        }

        public override void Fly()
        {
            // Do nothing !
            // This way is really not very good !
        }
    }
}
