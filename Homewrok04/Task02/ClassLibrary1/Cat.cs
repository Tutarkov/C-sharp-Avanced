using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cat: {Name} ({Age} years old). Lazy: {Lazy}. Lives left: {LivesLeft}");
        }
    }
}
