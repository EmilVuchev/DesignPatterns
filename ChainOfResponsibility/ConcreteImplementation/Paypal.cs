using ChainOfResponsibility.AbstractClasses;

namespace ChainOfResponsibility.ConcreteImplementation
{
    public class Paypal : Account
    {
        public Paypal(decimal balance)
        {
            this.balance = balance;
        }
    }
}
