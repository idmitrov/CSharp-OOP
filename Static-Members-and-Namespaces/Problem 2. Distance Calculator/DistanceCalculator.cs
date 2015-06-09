namespace Problem_2.Distance_Calculator
{
    using System;
    using Static_Members_and_Namespaces;
    using System.Linq;

    static class DistanceCalculator
    {
        //CALCULATE METHOD
        public static double Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = firstPoint.CordinateX - secondPoint.CordinateX,
                   deltaY = firstPoint.CordinateY - secondPoint.CordinateY,
                   deltaZ = firstPoint.CordinateZ - secondPoint.CordinateZ;

            return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
        }
    }
}
