namespace Problem_2.Animals
{

    public abstract class Cat : Animal
    {
        protected Cat(string animalName, byte animalAge, string gender) : base(animalName, animalAge, gender)
        {
        }

        public abstract override void ProduceSound();
    }
}
