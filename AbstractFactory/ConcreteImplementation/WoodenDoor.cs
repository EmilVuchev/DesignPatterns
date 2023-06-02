using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteImplementation
{
    internal class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door!");
        }
    }
}
