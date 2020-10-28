using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public class Square :  IRegularPolygone
    {
        public Square(int length)
        {
            NumberOfSides = 4;
            SideLength = length;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetArea()
        {
            var area = SideLength * SideLength;
           // area = Math.Round(area * 1.0);
            return area;
        }
        public double GetPerimeter()
        {
            return SideLength * 4;
        }
    }
}
