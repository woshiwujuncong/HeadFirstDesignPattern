namespace SimpleFactoryPattern.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("prepare pepperoni pizza ...");
        }

        public override void Bake()
        {
            Console.WriteLine("baking ...");

            Thread.Sleep(2000);

            Console.WriteLine("done !");
        }

        public override void Cut()
        {
            Console.WriteLine("cut pepperoni pizza into 8 pieces ...");
        }

        public override void Box()
        {
            Console.WriteLine("put into box ...");
        }
    }
}
