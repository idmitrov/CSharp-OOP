namespace Problem_2.Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, byte age, string gender) : base(name, age, gender)
        {   
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mmmmmmmmeow");
        }
    }
}
