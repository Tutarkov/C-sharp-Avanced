using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog: {Name} ({Age} years old). Favorite food: {FavoriteFood}");
        }
    }
}
