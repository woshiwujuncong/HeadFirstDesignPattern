using StrategyPattern3;

var mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.PerformFly();
mallardDuck.PerformQuack();
mallardDuck.PerformSwim();
Console.WriteLine();

var redheadDuck = new RedheadDuck();
redheadDuck.Display();
redheadDuck.PerformFly();
redheadDuck.PerformQuack();
redheadDuck.PerformSwim();
Console.WriteLine();

var rubberDuck = new RubberDuck();
rubberDuck.Display();
rubberDuck.PerformFly();
rubberDuck.PerformQuack();
rubberDuck.PerformSwim();
Console.WriteLine();

var decoyDuck = new DecoyDuck();
decoyDuck.Display();
decoyDuck.PerformFly();
decoyDuck.PerformQuack();
decoyDuck.PerformSwim();
Console.WriteLine();

Console.ReadLine();
