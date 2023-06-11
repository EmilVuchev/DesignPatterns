using ChainOfResponsibility.AbstractClasses;

namespace ChainOfResponsibility.ConcreteImplementation
{
    public class Bank : Account
    {
        public Bank(decimal balance)
        {
            this.balance = balance;
        }
    }
}
