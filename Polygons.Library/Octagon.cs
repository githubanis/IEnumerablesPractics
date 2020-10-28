using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public class Octagon : IRegularPolygone
    {
        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetArea()
        {
            var area = (2 * (1 + (Math.Sqrt(2))) * (SideLength * SideLength));
            area = Math.Round(area * 1.0);
            return area;
        }

        public double GetPerimeter()
        {
            return SideLength * NumberOfSides;
        }
    }
}
