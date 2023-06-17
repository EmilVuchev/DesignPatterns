namespace Visitor.Interfaces
{
    public interface IAnimal
    {
        void Accept(IAnimalOperation animalOperation);
    }
}
