using DecoratorPattern.Beverages;
using DecoratorPattern.Decorators;

Beverage darkRoast = new DarkRoast();
darkRoast = new Mocha(darkRoast);
darkRoast = new Soy(darkRoast);
darkRoast = new Soy(darkRoast);

Console.WriteLine(darkRoast.GetDescription());
Console.WriteLine(darkRoast.GetCost());
Console.WriteLine();

Beverage decaf = new Decaf();
decaf = new Whip(decaf);
decaf = new Milk(decaf);

Console.WriteLine(decaf.GetDescription());
Console.WriteLine(decaf.GetCost());

Console.ReadLine();
