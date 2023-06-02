using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteImplementation
{
    public class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am an iron door!");
        }
    }
}
