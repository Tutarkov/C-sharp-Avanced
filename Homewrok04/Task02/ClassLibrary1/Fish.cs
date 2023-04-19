using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish: {Name} ({Age} years old). Color: {Color}. Size: {Size}");
        }
    }
}
