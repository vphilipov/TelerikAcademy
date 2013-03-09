using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Euclidian3DSpace
{
    public static class PathStorage
    {
        public static void SavePath(Path route, string newFile)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            StreamWriter writer = new StreamWriter(newFile);
            using (writer)
            {
                foreach (var point in route.PointsPath)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string fileAddress)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Path loaded = new Path();
            StreamReader reader = new StreamReader(fileAddress);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = line.Substring(6, (line.Length - 7));
                    string[] coordinates = line.Split(new char[] {' ', ','},
                        StringSplitOptions.RemoveEmptyEntries);
                    double x = double.Parse(coordinates[0]);
                    double y = double.Parse(coordinates[1]);
                    double z = double.Parse(coordinates[2]);
                    Point3D nextPoint = new Point3D(x, y, z);
                    loaded.AddPoint(nextPoint);
                    line = reader.ReadLine();
                }
            }
            return loaded;
        }
    }
}
