namespace Problem_1.Persons
{
    using System;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email = null)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 1 || value > 100)
                {
                    Console.Error.WriteLine("Age range is between 1 - 100");
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (value != null)
                {
                    if (!value.Contains("@")
                        || value.Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
                    {
                        throw new ArgumentException("Email must contains a @ in case to be valid");
                    }

                }
                
                this.email = value;
            }
        }

        public override string ToString()
        {
            return this.Email == null
                ? "Name: " + this.Name + " Age: " + this.Age
                : "Name " + this.Name + " Age: " + this.Age + " Email: " + this.Email;
        }
    }
}
