using Composite.Interfaces;

namespace Composite.ConcreteImplementation
{
    public class Designer : IEmployee
    {
        private readonly string name;
        private readonly decimal salary;

        public Designer(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetRole()
        {
            return "Designer";
        }

        public decimal GetSalary()
        {
            return this.salary;
        }
    }
}
