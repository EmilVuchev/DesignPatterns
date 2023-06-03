using Builder.Interfaces;

namespace Builder.ConcreteImplementation
{
    public class Lettuce : IProduct
    {
        public Lettuce(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }

        public string Name => "lettuce";

        public bool IsAvailable { get; set; }
    }
}
