namespace Problem_3.Company_Hierarchy.Company.Interfaces
{
    using System.Collections.Generic;
    using Employees;

    interface IManager
    {
        IList<Employee> EmployeesSet { get; set; }
    }
}
