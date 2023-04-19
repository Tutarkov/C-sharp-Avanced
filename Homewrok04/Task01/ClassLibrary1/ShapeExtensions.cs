using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ShapeExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle {circle.Id} has radius {circle.Radius}");
            Console.WriteLine($"Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle {rectangle.Id} has sides {rectangle.SideA} and {rectangle.SideB}");
            Console.WriteLine($"Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}
