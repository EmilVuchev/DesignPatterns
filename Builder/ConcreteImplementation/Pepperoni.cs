using Builder.Interfaces;

namespace Builder.ConcreteImplementation
{
    public class Pepperoni : IProduct
    {
        public Pepperoni(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }

        public string Name => "pepperoni";

        public bool IsAvailable { get; set; }
    }
}
