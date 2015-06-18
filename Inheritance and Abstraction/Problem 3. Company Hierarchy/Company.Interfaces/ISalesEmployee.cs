namespace Problem_3.Company_Hierarchy.Company.Interfaces
{
    using System.Collections.Generic;
    using Employees.Resources;

    interface ISalesEmployee
    {
        IList<Sale> Sales { get; set; }
    }
}
