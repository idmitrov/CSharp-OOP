/*
    Write a static class DistanceCalculator 
    with a static method to calculate the distance between two points in the 3D space.
    Search in Internet how to calculate distance in the 3D Euclidian space.
*/

//NOTICE ADDED REFERENCE TO PROBLEM 1 Point3D CLASS to use the Point CLASS
namespace Problem_2.Distance_Calculator
{
    using System;
    using Static_Members_and_Namespaces;

    class Calculator
    {
        public static void Main()
        {
            var firstPoint = new Point3D(0, 1, 2);
            var secondPoint = new Point3D(5, 15, 25);
            double distanceBetweenPoints = DistanceCalculator.Calculate(firstPoint, secondPoint);

            Console.WriteLine(distanceBetweenPoints);
        }
    }
}
