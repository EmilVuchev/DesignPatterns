using Decorator.Interfaces;

namespace Decorator.ConcreteImplementation
{
    public class WhipCoffee : ICoffee
    {
        private readonly ICoffee coffee;

        public WhipCoffee(ICoffee coffee)
        {
            this.coffee = coffee ?? throw new ArgumentNullException("coffee", "Coffee should not be null");
        }

        public int GetCost()
        {
            return this.coffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return $"{this.coffee.GetDescription()}, whip";
        }
    }
}
