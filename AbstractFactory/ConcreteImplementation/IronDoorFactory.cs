using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteImplementation
{
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}
