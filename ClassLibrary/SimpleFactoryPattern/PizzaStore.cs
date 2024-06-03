namespace SimpleFactoryPattern
{
    public class PizzaStore
    {
        public void OrderPizza(string type)
        {
            var pizza = SimplePizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
