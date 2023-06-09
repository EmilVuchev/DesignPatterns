using Proxy.ConcreteImplementation;

var door = new SecureDoor(new LabDoor());
door.Open("invalid");

door.Open("$ecr@t");
door.Close();