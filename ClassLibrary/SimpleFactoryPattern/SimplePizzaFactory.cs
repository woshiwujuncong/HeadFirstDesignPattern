using SimpleFactoryPattern.Pizzas;

namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new CheesePizza(),
                "veggie" => new VeggiePizza(),
                "clam" => new ClamPizza(),
                "pepperoni" => new PepperoniPizza(),
                _ => throw new Exception("没有此类型的Pizza...")
            };
        }
    }
}
