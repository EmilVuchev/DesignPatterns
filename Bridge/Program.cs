using Bridge.ConcreteImplementation;

var darkTheme = new DarkTheme();
var lightTheme = new LightTheme();

var aboutPageDark = new About(darkTheme);
var aboutPageLight = new About(lightTheme);

Console.WriteLine(aboutPageDark.GetContent());
Console.WriteLine(aboutPageLight.GetContent());