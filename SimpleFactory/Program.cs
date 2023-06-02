using SimpleFactory.ConcreteImplementation;

var doorFactory = new DoorFactory();
var door = doorFactory.MakeDoor(2, 1);

Console.WriteLine(door);
