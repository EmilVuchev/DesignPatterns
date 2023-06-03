using Builder.ConcreteImplementation;

var burger = new BurgerBuilder(5)
    .AddCheese()
    .AddLettuce()
    .AddPepperoni()
    .AddTomato()
    .Build();

var burgerDescription = burger.GetDescription();

Console.WriteLine(burgerDescription);
