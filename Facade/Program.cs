using Facade.ConcreteImplementation;

var computer = new Computer();
var computerFacade = new ComputerFacade(computer);

computerFacade.TurnOn();
Console.WriteLine();
computerFacade.TurnOff();