using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidian3DSpace;

namespace TestPoint3D
{
    class Program
    {
        static void Main()
        {
            Point3D myPoint = new Point3D(1, 2, 3);
            Console.WriteLine("The ToString() overload: {0}", myPoint);
            Console.WriteLine();

            Console.WriteLine("The static point 0: {0}", Point3D.CentrePoint);
            Console.WriteLine();

            Point3D myOtherPoint = new Point3D(3, 2, 1);
            double pointsDistance = CalculateDistance.Distance(myPoint, myOtherPoint);
            Console.WriteLine("Calculated distance: {0}", pointsDistance);
            Console.WriteLine();

            Path route = new Path();
            route.AddPoint(Point3D.CentrePoint);
            route.AddPoint(myPoint);
            route.AddPoint(myOtherPoint);
            route.AddPoint(new Point3D(1.1, 2.2, 3.82743658793465));
            Console.WriteLine("One of the points in the path: {0}", route.PointsPath[1]);
            Console.WriteLine();

            PathStorage.SavePath(route, "../../test.txt");

            Path loadedRoute = PathStorage.LoadPath("../../test.txt");
            Console.WriteLine("Print path loaded from file");
            foreach (var point in loadedRoute.PointsPath)
            {
                Console.WriteLine(point);
            }
        }
    }
}
