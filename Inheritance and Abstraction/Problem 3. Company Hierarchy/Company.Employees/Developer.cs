namespace Problem_3.Company_Hierarchy.Company.Employees
{
    using System.Collections.Generic;
    using Resources;
    using Interfaces;

    class Developer : Employee, IDeveloper
    {
        public Developer(string firstName, string lastName, long id, decimal salary, string department, IList<Project> projectsList) 
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projectsList;
        }

        public IList<Project> Projects { get; set; }
    }
}
