using Composite.Interfaces;

namespace Composite.ConcreteImplementation
{
    public class Organization
    {
        protected List<IEmployee> employees;

        public Organization()
        {
            this.employees = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public decimal GetNetSalaries() 
        {
            var result = 0m;

            foreach (var employee in this.employees)
            {
                result += employee.GetSalary();
            }

            return result;
        }
    }
}
