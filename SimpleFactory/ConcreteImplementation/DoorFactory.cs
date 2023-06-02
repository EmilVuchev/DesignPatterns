using SimpleFactory.Interfaces;

namespace SimpleFactory.ConcreteImplementation
{
    public class DoorFactory
    {
        public IDoor MakeDoor(int height, int width)
        {
            return new WoodenDoor(height, width);
        }
    }
}
