using Singleton.ConcreteImplementation;

var presidentA = President.GetInstance();
var presidentB = President.GetInstance();

Console.WriteLine(presidentA == presidentB);
