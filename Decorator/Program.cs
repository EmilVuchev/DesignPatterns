using Decorator.ConcreteImplementation;

var myCoffee = new SimpleCoffee();
Console.WriteLine($"{myCoffee.GetCost():c}"); // $ 5.00
Console.WriteLine(myCoffee.GetDescription()); // Simple Coffee

var milkCoffee = new MilkCoffee(myCoffee);
Console.WriteLine($"{milkCoffee.GetCost():c}");
Console.WriteLine($"{milkCoffee.GetDescription()}");

var whipCoffee = new WhipCoffee(milkCoffee);
Console.WriteLine($"{whipCoffee.GetCost():c}");
Console.WriteLine($"{whipCoffee.GetDescription()}");

var vanillaCoffee = new VanillaCoffee(whipCoffee);
Console.WriteLine($"{vanillaCoffee.GetCost():c}");
Console.WriteLine($"{vanillaCoffee.GetDescription()}");
