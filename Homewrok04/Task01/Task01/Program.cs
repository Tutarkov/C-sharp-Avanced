
using System.Drawing;

namespace Task01

{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ShapeDb<Shape>();

            // Add some circles to the ShapeDb
            var circle1 = new Circle { Id = 1, Radius = 5 };
            var circle2 = new Circle { Id = 2, Radius = 10 };
            db.AddShape(circle1);
            db.AddShape(circle2);

            // Add some rectangles to the ShapeDb
            var rectangle1 = new Rectangle { Id = 3, SideA = 2, SideB = 6 };
            var rectangle2 = new Rectangle { Id = 4, SideA = 4, SideB = 8 };
            db.AddShape(rectangle1);
            db.AddShape(rectangle2);

            // Print the areas and perimeters of all shapes in the ShapeDb
            db.PrintAreas();
            db.PrintPerimeters();

            // Use extension methods to print info for a specific circle and rectangle
            circle1.PrintInfo();
            rectangle2.PrintInfo();
        }
    }
}