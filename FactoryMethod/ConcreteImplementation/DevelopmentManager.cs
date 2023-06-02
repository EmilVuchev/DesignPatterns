using FactoryMethod.AbstractClasses;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteImplementation
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }
}
