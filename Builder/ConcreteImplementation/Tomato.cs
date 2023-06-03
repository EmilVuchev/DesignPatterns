using Builder.Interfaces;

namespace Builder.ConcreteImplementation
{
    public class Tomato : IProduct
    {
        public Tomato(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }

        public string Name => "tomato";

        public bool IsAvailable { get; set; }
    }
}
