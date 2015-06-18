namespace Problem_3.Company_Hierarchy.Company.Employees
{
    using Interfaces;
    using System.Collections.Generic;

    class Manager : Employee, IManager
    {
        public Manager(string firstName, string lastName, long id, decimal salary, string department, IList<Employee> employeeSet ) 
            : base(firstName, lastName, id, salary, department)
        {
            this.EmployeesSet = employeeSet;
        }

        public IList<Employee> EmployeesSet { get; set; }
    }
}
