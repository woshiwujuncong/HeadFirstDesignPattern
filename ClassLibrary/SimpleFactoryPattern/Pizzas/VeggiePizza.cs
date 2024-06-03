namespace SimpleFactoryPattern.Pizzas
{
    internal class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("prepare veggie pizza ...");
        }

        public override void Bake()
        {
            Console.WriteLine("baking ...");

            Thread.Sleep(1000);

            Console.WriteLine("done !");
        }

        public override void Cut()
        {
            Console.WriteLine("cut veggie pizza into 8 pieces ...");
        }

        public override void Box()
        {
            Console.WriteLine("put into box ...");
        }
    }
}
