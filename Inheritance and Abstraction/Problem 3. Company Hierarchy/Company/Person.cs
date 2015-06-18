namespace Problem_3.Company_Hierarchy.Company
{
    using System;
    using Interfaces;

    public abstract class Person : IPerson
    {
        // FIELDS
        private string firstName;
        private string lastName;
        private long id;

        // CONSTRUCTOR
        protected Person(string firstName, string lastName, long id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
        }

        // FIRST NAME
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FirstName", "cannot be NULL or Whitespace.");
                }
                this.firstName = value;
            }
        }

        // LAST NAME
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("LastName", "cannot be NULL or Whitespace.");
                }
                this.lastName = value;
            }
        }

        // ID
        public long Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Id", "cannto be negative value.");
                }
                this.id = value;
            }
        }

        // OVERRIDE TO STRING
        public override string ToString()
        {
            string personInfo = String.Format("Name: {0} {1}, ID: {2}, Position: {3}",
                this.firstName, this.lastName, this.id, this.GetType().Name);

            return personInfo;
        }
    }
}
