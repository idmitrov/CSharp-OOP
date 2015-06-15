namespace Problem_2.Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string animalName, byte animalAge, string gender) : base(animalName, animalAge, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
