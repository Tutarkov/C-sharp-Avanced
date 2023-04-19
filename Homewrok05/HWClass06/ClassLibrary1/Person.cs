using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public List<Dog> Dog { get; set; }

        public Person(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
            Dog = new List<Dog>();
        }
    }
}
