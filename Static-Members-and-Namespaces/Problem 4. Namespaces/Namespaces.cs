/*
    Design a group of classes to work with geometric figures.
    Put them into namespaces. You do not need to implement the classes, just create them and put them into namespaces.
    Make sure the files are placed in directories corresponding to the namespaces.

    Namespace Geometry.Geometry2D holds classes:
•	Point2D
•	Figure2D
•	Square
•	Rectangle
•	Polygon
•	Circle
•	Ellipse
•	DistanceCalculator2D

    Namespace Geometry.Geometry3D holds classes:
•	Point3D
•	Path3D
•	DistanceCalculator3D

    Namespace Geometry.Storage holds classes:
•	GeometryXMLStorage
•	GeometryBinaryStorage
•	GeometrySVGStorage

    Namespace Geometry.UI holds classes:
•	Screen2D
•	Screen3D
*/

namespace Problem_4.Namespaces
{
    using System;
    using Problem_4.Namespaces.Geometry.Geometry2D;
    using Problem_4.Namespaces.Geometry.Geometry3D;
    using Problem_4.Namespaces.Geometry.Storage;
    using Problem_4.Namespaces.Geometry.UI;

    class Namespaces
    {
        static void Main(string[] args)
        {
            //GEOMETRY

            //2D NAMESPACE
            Point2D point2D = new Point2D();

            //3D NAMESPACE
            Point3D point3D = new Point3D();

            //STORAGE NAMESPACE
            GeometryBinaryStorage binStorage = new GeometryBinaryStorage();

            //UI NAMESPACE
            Screen2D screen2D = new Screen2D();
            Screen3D screen3D = new Screen3D();
        }
    }
}
