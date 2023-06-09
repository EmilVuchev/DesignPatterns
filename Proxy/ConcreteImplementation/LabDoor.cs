using Proxy.Interfaces;

namespace Proxy.ConcreteImplementation
{
    public class LabDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Closing lab door");
        }

        public void Open()
        {
            Console.WriteLine("Opening lab door");
        }
    }
}
