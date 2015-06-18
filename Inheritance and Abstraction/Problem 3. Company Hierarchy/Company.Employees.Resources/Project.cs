namespace Problem_3.Company_Hierarchy.Company.Employees.Resources
{
    using System;

    class Project
    {
        // FIELDS
        private string projectName;
        private DateTime projectStartDate;
        private string projectDetails;
        private string projectState;

        // CONSTRUCTOR
        public Project(string name, DateTime date, string details, string state)
        {
            this.ProjectName = name;
            this.ProjectDate = date;
            this.ProjectDetails = details;
            this.ProjectState = state;
        }

        // PROJECT NAME
        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProjectName", "cannot be NULL or Whitespace.");
                }
                this.projectName = value;
            }
        }

        // PROJECT START DATE
        public DateTime ProjectDate
        {
            get { return this.projectStartDate; }
            set
            {
                if (value.GetType() != typeof(DateTime))
                {
                    throw new ArgumentException("ProjectStartDate", "is not valid DateTime format.");
                }

                this.projectStartDate = value;
            }
        }

        // PROJECT DETAILS
        public string ProjectDetails
        {
            get { return this.projectDetails; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProjectDetails", "cannot be NULL or Whitespace.");
                }
                this.projectDetails = value;
            }
        }

        // PROJECT STATE
        public string ProjectState
        {
            get { return this.projectState; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProjectState", "cannot be NULL or Whitespace.");
                }

                if (value != "open" && value != "closed")
                {
                    Console.Error.WriteLine("Possible project states: [open/closed].");
                    throw new ArgumentException("Unknown ProjectState.");
                }

                this.projectState = value;
            }
        }

        // METHODS

        // PROJECT CLOSE
        public void CloseProject()
        {
            this.projectState = "closed";
        }
    }
}
