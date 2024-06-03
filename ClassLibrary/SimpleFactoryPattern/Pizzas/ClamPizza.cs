namespace SimpleFactoryPattern.Pizzas
{
    public class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("prepare clam pizza ...");
        }

        public override void Bake()
        {
            Console.WriteLine("baking ...");

            Thread.Sleep(1000);

            Console.WriteLine("done !");
        }

        public override void Cut()
        {
            Console.WriteLine("cut clam pizza into 8 pieces ...");
        }

        public override void Box()
        {
            Console.WriteLine("put into box ...");
        }
    }
}
