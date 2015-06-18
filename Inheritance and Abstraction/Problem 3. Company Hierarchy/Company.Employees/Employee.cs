namespace Problem_3.Company_Hierarchy.Company.Employees
{
    using System;
    using Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        // FIELDS
        private decimal salary;
        private string department;

        // CONSTRUCTOR
        protected Employee(string firstName, string lastName, long id, decimal salary, string department) 
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        // SALARY
        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary", "cannot be negative value.");
                }
                this.salary = value;
            }
        }

        // DEPARTAMENT
        public string Department
        {
            get { return this.department; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Department", "cannot be NULL or Whitespace.");
                }


                if (value != "Production" && value != "Accounting"
                    && value != "Sales" && value != "Marketing")
                {
                    Console.Error.WriteLine("Allowed departments: Production, Accounting, Sales, Marketing.");
                    throw new ArgumentException("Unknown department.");
                }
                this.department = value;
            }
        }

        public override string ToString()
        {
            string employeeInfo = String.Format("Salary: {0}, Departament: {1}",
                this.salary, this.department);

            return base.ToString() + "\r\n" + employeeInfo;
        }
    }
}
