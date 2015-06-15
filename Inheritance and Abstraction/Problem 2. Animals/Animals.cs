/*
    •   Create an abstract class Animal holding name, age and gender.

    •	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. 
        Dogs, frogs and cats are animals. Kittens are female cats and Tomcats are male cats. 
        Define useful constructors and methods. 

    •	Define an interface ISoundProducible which holds the method ProduceSound(). 
        All animals should implement this interface. 
        The ProduceSound() method should produce a specific sound depending on the animal invoking it (e.g. the dog should bark).

    •	Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ.
*/

namespace Problem_2.Animals
{
    using System;
    using System.Linq;

    class Animals
    {
        static void Main(string[] args)
        {
            // ANIMALS
            var animals = new Animal[]
            {
                new Dog("Cesar", 7, "Male"),
                new Dog("Franky", 8, "Male"),
                new Dog("Rex", 1, "Male"),
                new Dog("Lesley", 12, "Female"),
                new Frog("Froggy", 10, "Male"),
                new Frog("Gosho", 20, "Male"),
                new Frog("Ganio", 12, "Male"),
                new Frog("Kiko", 15, "Male"),
                new Kitten("Kitty", 2, "Female"),
                new Kitten("Katty", 4, "Female"),
                new Tomcat("Tom", 3, "Male"),
                new Tomcat("Pesho", 5, "Male")
            };

            // AGEs AVERAGE
            int dogsAvgAge = (int)animals.OfType<Dog>().Average(animal => animal.Age);
            int frogsAvgAge = (int)animals.OfType<Frog>().Average(animal => animal.Age);
            int catsAvgAge = (int)animals.OfType<Cat>().Average(animal => animal.Age);

            // PRINT AVG AGE FOR EACH ANIMAL
            Console.WriteLine("Dogs avg age: {0}\r\nCats avg age: {1}\r\nFrogs avg age: {2}\r\n",
                dogsAvgAge, catsAvgAge, frogsAvgAge);
        }
    }
}
