using Template_Method.ConcreteImplementation;

var androidBuilder = new AndroidBuilder();
androidBuilder.Build();

var iosBuilder = new IosBuilder();
iosBuilder.Build();