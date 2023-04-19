using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ShapeDb<T> where T : Shape
    {
        private List<T> shapes = new List<T>();

        public void AddShape(T shape)
        {
            shapes.Add(shape);
        }

        public void PrintAreas()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape {shape.Id} has area of {shape.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape {shape.Id} has perimeter of {shape.GetPerimeter()}");
            }
        }
    }
}
