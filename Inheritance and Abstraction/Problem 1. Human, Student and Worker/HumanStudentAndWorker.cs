/*
    Define an abstract class Human holding a first name and a last name.
•	Define a class Student derived from Human that has a field faculty number (5-10 digits / letters).
•	Define a class Worker derived from Human
    with fields WeekSalary and WorkHoursPerDay
    and method MoneyPerHour() that returns the payment earned by hour by the worker. 
•	Define the proper constructors and properties for the classes in your class hierarchy.
•	Initialize a list of 10 students and sort them by faculty number in ascending order
    (use a LINQ query or the OrderBy() extension method).
    Initialize a list of 10 workers and sort them by payment per hour in descending order.
•	Merge the lists and then sort them by first name and last name.
*/

namespace Problem_1.Human__Student_and_Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            // STUDENTS
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshev", "31A22F51"),
                new Student("Ivan", "Asenov", "Z1Z22C20"),
                new Student("Georgi", "Georgiev", "22Z42C21"),
                new Student("Misho", "Dimitrov", "41A93C12"),
                new Student("Straxil", "Kotkov", "Z4FF2D21")
            };

            // WORKERS
            var workers = new List<Worker>()
            {
                new Worker("Barovec", "Mixov", 2000, 2),
                new Worker("Ivo", "Siromaxov", 200, 12),
                new Worker("Joro", "Ciciev", 1000, 8),
                new Worker("Straxil", "Murzelievski", 700, 1)
            };

            // HUMANS
            var humans = new List<Human>();

            Console.WriteLine("Students:\r\n");

            foreach (var student in students.OrderBy(x => x.FacultyNumber))
            {
                Console.WriteLine("{0} -> Faculty Number: {1}", student, student.FacultyNumber);
                humans.Add(student);
            }

            Console.WriteLine("\r\nWorkers:\r\n");

            foreach (var worker in workers.OrderByDescending(x => x.MoneyPerHours()))
            {
                Console.WriteLine("{0} -> Money per hour: {1:0.00}lv.", worker, worker.MoneyPerHours());
                humans.Add(worker);
            }

            Console.WriteLine("\r\nHumans:\r\n");

            foreach (var human in humans.OrderBy(x => x.FirstName))
            {
                Console.WriteLine(human + " -> " + human.GetType().Name);              
            }
        }
    }
}
