namespace Problem_2.Animals
{
    using System;

    public abstract class Animal : ISoundProducible
    {
        private string name;
        private byte age;
        private string gender;

        protected Animal(string animalName, byte animalAge, string animalGender)
        {
            this.Name = animalName;
            this.Age = animalAge;
            this.Gender = animalGender;
        }

        // NAME
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException();
                }
                this.name = value;
            }
        }

        // AGE
        public byte Age { get; set; }

        // GENDER
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid gender value.");
                }
                this.gender = value;
            }
        }

        // PRODUCE SOUND
        public abstract void ProduceSound();

        // OVERRIDE TO STRING
        public override string ToString()
        {
            return String.Format("Animal type: {0}, Name: {1}, Age: {2}, Gender: {3}", 
                this.GetType().Name, this.Name, this.Age, this.Gender);
        }
    }
}
