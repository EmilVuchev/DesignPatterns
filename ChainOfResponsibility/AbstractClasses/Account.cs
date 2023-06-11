namespace ChainOfResponsibility.AbstractClasses
{
    public abstract class Account
    {
        private Account successor;
        protected decimal balance;

        public void SetNext(Account successor)
        {
            this.successor = successor;
        }

        public void Pay(decimal amountToPay)
        {
            var canPay = CanPay(amountToPay);

            if (canPay)
            {
                Console.WriteLine($"Paid {amountToPay:c} using {this.GetType().Name}.");
            }
            else if (this.successor != null)
            {
                Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
                this.successor.Pay(amountToPay);
            }
            else
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }

        private bool CanPay(decimal amountToPay)
        {
            return balance >= amountToPay;
        }
    }
}
