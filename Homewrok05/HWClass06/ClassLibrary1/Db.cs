using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Db
    {
        public static List<Person> People { get; set; }
        public static List<Dog> Dogs { get; set; }

        static Db()
        {
            People = new List<Person>();
            Dogs = new List<Dog>();
        }
    }
}
