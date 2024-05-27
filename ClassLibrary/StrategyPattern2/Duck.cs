namespace StrategyPattern2
{
    public abstract class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming ~");
        }

        public abstract void Display();
    }
}
