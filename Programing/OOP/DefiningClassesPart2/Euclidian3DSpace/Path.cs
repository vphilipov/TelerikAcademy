using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    public class Path
    {
        private List<Point3D> pointsPath;

        public Path()
        {
            PointsPath = new List<Point3D>();
        }

        public List<Point3D> PointsPath
        {
            get
            {
                return this.pointsPath;
            }

            set
            {
                this.pointsPath = value;
            }
        }

        public void AddPoint(Point3D newPoint)
        {
            pointsPath.Add(newPoint);
        }
    }
}
