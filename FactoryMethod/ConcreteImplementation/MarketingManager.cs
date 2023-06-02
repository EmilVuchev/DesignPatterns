using FactoryMethod.AbstractClasses;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteImplementation
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
