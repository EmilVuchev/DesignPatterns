using Decorator.Interfaces;

namespace Decorator.ConcreteImplementation
{
    public class SimpleCoffee : ICoffee
    {
        public int GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
