namespace Problem_2.Animals
{
    using System;

    class Frog : Animal
    {
        public Frog(string animalName, byte animalAge, string gender) : base(animalName, animalAge, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwa Kwa");
        }
    }
}
