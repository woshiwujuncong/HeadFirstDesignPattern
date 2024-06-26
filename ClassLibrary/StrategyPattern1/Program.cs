﻿using StrategyPattern1;

var mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.Fly();
mallardDuck.Quack();
mallardDuck.Swim();
Console.WriteLine();

var redheadDuck = new RedheadDuck();
redheadDuck.Display();
redheadDuck.Fly();
redheadDuck.Quack();
redheadDuck.Swim();
Console.WriteLine();

var rubberDuck = new RubberDuck();
rubberDuck.Display();
rubberDuck.Fly();
rubberDuck.Quack();
rubberDuck.Swim();
Console.WriteLine();

var decoyDuck = new DecoyDuck();
decoyDuck.Display();
decoyDuck.Fly();
decoyDuck.Quack();
decoyDuck.Swim();
Console.WriteLine();

Console.ReadLine();
