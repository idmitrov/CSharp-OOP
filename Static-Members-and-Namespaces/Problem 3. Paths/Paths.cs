/*
    Create a class Path3D to hold a sequence of points in 3D space. 
    Create a static class Storage with static methods to save and load paths from a text file. 
    Use a file format of your choice. Ensure you close correctly all files with the "using" statement.
*/


//NOTICE ADDED REFERENCE TO PROBLEM 1 Point3D, TO USE THE Point3D CLASS (Functionaly)

using System.Collections.Generic;
using Static_Members_and_Namespaces;

namespace Problem_3.Paths
{
    using System;

    class Paths
    {
        static void Main()
        {
            var myPath = new Path3D(new List<Point3D>()
            {
                new Point3D(2, 13, 14),
                new Point3D(1, 22, 41),
                new Point3D(5, 23, 43),
                new Point3D(7, 8, 24),
                new Point3D(4, 2, 44),
            });

            //SAVE TO FILE path.txt
            Storage.SavePath("../../path.txt", myPath.ToString());

            //LOAD FROM FILE path.txt
            Console.WriteLine("Loaded path:\r\n" + Storage.LoadPath("../../path.txt"));
        }
    }
}
