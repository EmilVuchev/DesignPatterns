namespace AbstractFactory.Interfaces
{
    public interface IDoorFactory
    {
        IDoor MakeDoor();

        IDoorFittingExpert MakeFittingExpert();
    }
}
