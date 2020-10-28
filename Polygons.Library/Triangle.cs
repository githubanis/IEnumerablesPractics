using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public  class Triangle :  IRegularPolygone
    {
        public Triangle(int length)
        {
            NumberOfSides = 3;
            SideLength = length;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetArea()
        {
            var area = SideLength * SideLength * Math.Sqrt(3) / 4; ;
            area = Math.Round(area * 1.0);
            return area;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}
