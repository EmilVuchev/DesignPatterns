using Prototype.ConcreteImplementation;

var originalSheep = new Sheep("Dolly", "Mountain Sheep");
Console.WriteLine(originalSheep.Name);
Console.WriteLine(originalSheep.Category);

var clonedSheep = originalSheep.Clone();
clonedSheep.Name = "Jolly";

Console.WriteLine(clonedSheep.Name);
Console.WriteLine(clonedSheep.Category);
