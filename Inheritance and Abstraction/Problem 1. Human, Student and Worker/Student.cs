using System;

namespace Problem_1.Human__Student_and_Worker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number length allowed [5 - 10].");
                }
                this.facultyNumber = value;
            }
        }
    }
}
