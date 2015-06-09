namespace Problem_3.Paths
{
    using System;
    using System.Collections.Generic;
    using Static_Members_and_Namespaces;

    public class Path3D
    {
        private List<Point3D> sequenceOfPoints;

        public Path3D(List<Point3D> pathPoints)
        {
            this.SequenceOfPoints = pathPoints;
        }

        public List<Point3D> SequenceOfPoints 
        {
            get { return this.sequenceOfPoints; }
            set
            {
                //if (value.Count < 1)
                //{
                //    throw new ArgumentException("Path can not be empty");
                //}
                this.sequenceOfPoints = value;
            }
        }

        public override string ToString()
        {
            string path = String.Empty;
            int pointIndex = 1;

            foreach (var point in this.sequenceOfPoints)
            {
                path += "Point " + pointIndex + " Coordinates " + point + "\r\n";
                pointIndex++;
            }

            return path;
        }
    }
}
