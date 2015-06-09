namespace Static_Members_and_Namespaces
{
    using System;

    class MainPointSystem
    {
        static void Main()
        {
            //CREATE 3D POINTS (X, Y, Z)
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(55, 32, -22);

            //PRINT STARTING POINT (X0 Y0 Z0)
            Console.WriteLine(Point3D.StartingPoint);

            //PRINT CORDINATES
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
        }
    }
}
