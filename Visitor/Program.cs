using Visitor.ConcreteImplementation;

var monkey = new Monkey();
var lion = new Lion();
var dolphin = new Dolphin();

var speak = new Speak();

monkey.Accept(speak);
lion.Accept(speak);
dolphin.Accept(speak);

var jump = new Jump();

monkey.Accept(speak);
monkey.Accept(jump);

lion.Accept(speak);
lion.Accept(jump);

dolphin.Accept(speak);
dolphin.Accept(jump);