using DecoratorPattern1.Beverages;

var espresso = new Espresso
{
    Milk = true
};

var darkRoast = new DarkRoast
{
    Soy = true,
    Whip = true
};

Console.WriteLine($"espresso cost : {espresso.Cost()}");

Console.WriteLine($"dark roast cost : {darkRoast.Cost()}");

Console.ReadLine();
