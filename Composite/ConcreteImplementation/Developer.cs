using Composite.Interfaces;

namespace Composite.ConcreteImplementation
{
    public class Developer : IEmployee
    {
        private readonly string name;
        private readonly decimal salary;

        public Developer(string name, decimal salary)
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
            return "Developer";
        }

        public decimal GetSalary()
        {
            return this.salary;
        }
    }
}
