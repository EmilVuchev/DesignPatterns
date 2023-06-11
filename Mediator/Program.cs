using Mediator.ConcreteImplementation;

var chatRoom = new ChatRoom();

var jane = new User("Jane", chatRoom);
var john = new User("John", chatRoom);

jane.Send("Hello");
john.Send("Hi! How are you?");
