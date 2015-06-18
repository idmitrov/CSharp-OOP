namespace Problem_3.Company_Hierarchy.Company.Interfaces
{
    using System.Collections.Generic;
    using Employees.Resources;


    interface IDeveloper
    {
        IList<Project> Projects { get; set; }
    }
}
