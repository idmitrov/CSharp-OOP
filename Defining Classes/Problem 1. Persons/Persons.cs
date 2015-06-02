/*
    Define a class Person that has name, age and email. 
    The name and age are mandatory. The email is optional.
    Define properties that accept non-empty name and age in the range [1...100]. 
    In case of invalid argument, throw an exception. 
    Define a property for the email that accepts either null or non-empty string containing '@'. 
    Define two constructors. The first constructor should take name, age and email.
    The second constructor should take name and age only and call the first constructor. 
    Implement the ToString() method to enable printing persons at the console.
*/

namespace Problem_1.Persons
{
    using System;

    class Persons
    {
        static void Main(string[] args)
        {
            Person peshoPerson = new Person("Mitko", 10, "pesho@example.com");
            Person goshoPerson = new Person("Gosho", 22);

            Console.WriteLine(peshoPerson);
            Console.WriteLine(Environment.NewLine + goshoPerson);
        }
    }
}
