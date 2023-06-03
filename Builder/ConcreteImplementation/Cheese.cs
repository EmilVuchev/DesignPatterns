using Builder.Interfaces;

namespace Builder.ConcreteImplementation
{
    public class Cheese : IProduct
    {
        public Cheese(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }

        public string Name => "cheese";

        public bool IsAvailable { get; set; }
    }
}
