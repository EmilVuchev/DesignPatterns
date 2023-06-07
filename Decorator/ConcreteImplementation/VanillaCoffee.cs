using Decorator.Interfaces;

namespace Decorator.ConcreteImplementation
{
    public class VanillaCoffee : ICoffee
    {
        private readonly ICoffee coffee;

        public VanillaCoffee(ICoffee coffee)
        {
            this.coffee = coffee ?? throw new ArgumentNullException("coffee", "Coffee should not be null");
        }

        public int GetCost()
        {
            return this.coffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return $"{this.coffee.GetDescription()}, vanilla";
        }
    }
}
