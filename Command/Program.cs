using Command.ConcreteImplementation;

var bulb = new Bulb();
var turnOnCommand = new TurnOn(bulb);
var turnOffCommand = new TurnOff(bulb);

var remote = new RemoteControl();
remote.Submit(turnOnCommand);
remote.Undo(turnOnCommand);
remote.Redo(turnOnCommand);

remote.Submit(turnOffCommand);
