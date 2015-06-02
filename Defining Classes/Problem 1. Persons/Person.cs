namespace Problem_1.Persons
{
    using System;

    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
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
                    Console.Error.WriteLine("Age must be a number between 1 - 100");
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
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must contain @");
                }

                if (value != null && value.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
                {
                    throw new ArgumentException("Email must contain only one @");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return email == null
                ? String.Format("Name: {0}\r\nAge: {1}", this.name, this.age)
                : String.Format("Name: {0}\r\nAge: {1}\r\nEmail: {2}", this.name, this.age, this.email);
        }
    }
}
