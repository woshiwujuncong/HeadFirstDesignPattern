namespace SimpleFactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("prepare cheese pizza ...");
        }

        public override void Bake()
        {
            Console.WriteLine("baking ...");

            Thread.Sleep(2000);

            Console.WriteLine("done !");
        }

        public override void Cut()
        {
            Console.WriteLine("cut cheese pizza into 8 pieces ...");
        }

        public override void Box()
        {
            Console.WriteLine("put into box ...");
        }
    }
}
