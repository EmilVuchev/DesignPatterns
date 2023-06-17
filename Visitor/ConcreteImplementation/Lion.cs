using Visitor.Interfaces;

namespace Visitor.ConcreteImplementation
{
    public class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Roaar!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitLion(this);
        }
    }
}