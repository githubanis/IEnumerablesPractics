using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            IRegularPolygone square = new Square(4);
            DisplayPolygone("Squre", square);

            Console.WriteLine("---- X ----");

            IRegularPolygone triangle = new Triangle(4);
            DisplayPolygone("Triangle", triangle);

            Console.WriteLine("---- X ----");

            IRegularPolygone octagone = new Octagon(4);
            DisplayPolygone("Octagone", octagone);
        }

        private static void DisplayPolygone(string v, IRegularPolygone regularPolygone)
        {
            var area = regularPolygone.GetArea();
            area = Math.Round(area * 1.0);
            
            Console.WriteLine($"Area of the {v} is: {area}");
            Console.WriteLine($"Sides of the {v} is: {regularPolygone.NumberOfSides}");
            Console.WriteLine($"Length of one side of the {v} is: {regularPolygone.SideLength}");
            Console.WriteLine($"Perimeter of the {v} is: {regularPolygone.GetPerimeter()}");
        }
    }
}