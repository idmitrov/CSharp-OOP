namespace Problem_2.Animals
{
    using System;

    class Dog : Animal
    {
        public Dog(string animalName, byte animalAge, string gender) : base(animalName, animalAge, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
