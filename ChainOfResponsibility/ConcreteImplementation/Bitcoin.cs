using ChainOfResponsibility.AbstractClasses;

namespace ChainOfResponsibility.ConcreteImplementation
{
    public class Bitcoin : Account
    {
        public Bitcoin(decimal balance)
        {
            this.balance = balance;
        }
    }
}
