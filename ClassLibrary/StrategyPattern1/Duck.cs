namespace StrategyPattern1
{
    public abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack quack ~");
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming ~");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I'm flying ~");
        }

        public abstract void Display();
    }
}
