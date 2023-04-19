using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
