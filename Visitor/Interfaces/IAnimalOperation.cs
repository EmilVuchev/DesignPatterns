using Visitor.ConcreteImplementation;

namespace Visitor.Interfaces
{
    public interface IAnimalOperation
    {
        void VisitMonkey(Monkey monkey);

        void VisitLion(Lion lion);

        void VisitDolphin(Dolphin dolphin);
    }
}