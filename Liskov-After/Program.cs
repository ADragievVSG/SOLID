using Liskov_After.Classes;

Fruit apple = new Apple();
Fruit orange = new Orange();

Console.WriteLine($"Apple color: {apple.GetColor()}");
Console.WriteLine($"Orange color: {orange.GetColor()}");