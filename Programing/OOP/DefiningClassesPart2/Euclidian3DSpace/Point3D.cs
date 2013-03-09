using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D centrePoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D CentrePoint
        {
            get { return centrePoint; }
        }
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        
        public override string ToString()
        {
            return string.Format("Point({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
