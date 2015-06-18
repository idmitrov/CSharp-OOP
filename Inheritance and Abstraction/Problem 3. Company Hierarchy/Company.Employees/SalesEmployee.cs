namespace Problem_3.Company_Hierarchy.Company.Employees
{
    using System.Collections.Generic;
    using Resources;
    using Interfaces;

    class SalesEmployee : Employee, ISalesEmployee
    {
        public SalesEmployee(string firstName, string lastName, long id, decimal salary, string department, IList<Sale> sales ) 
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }

        public IList<Sale> Sales { get; set; }
    }
}
