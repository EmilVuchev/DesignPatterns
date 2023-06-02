using AbstractFactory.ConcreteImplementation;

var woodenDoorFactory = new WoodenDoorFactory();
var woodenDoor = woodenDoorFactory.MakeDoor();
var carpenter = woodenDoorFactory.MakeFittingExpert();

woodenDoor.GetDescription();
carpenter.GetDescription();

var ironDoorFactory = new IronDoorFactory();

var ironDoor = ironDoorFactory.MakeDoor();
var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

ironDoor.GetDescription();
ironDoorFittingExpert.GetDescription();