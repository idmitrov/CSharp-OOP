namespace Static_Members_and_Namespaces
{
    using System;

    public class Point3D
    {
        //READ ONLY CONST
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        //CONSTRUCTOR
        public Point3D(int cordX, int cordY, int cordZ)
        {
            this.CordinateX = cordX;
            this.CordinateY = cordY;
            this.CordinateZ = cordZ;
        }
        
        //STATIC PROP RETURN STATIC FIELD START OF THE CORDINATE SYSTEM
        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        //AUTO PROPS (X, Y, Z) GET/SET
        public int CordinateX { get; set; }
        public int CordinateY { get; set; }
        public int CordinateZ { get; set; }

        //OVERRIDE TO STRING
        public override string ToString()
        {
            return String.Format("{{ {0}, {1}, {2} }}", this.CordinateX, this.CordinateY, this.CordinateZ);
        }
    }
}
