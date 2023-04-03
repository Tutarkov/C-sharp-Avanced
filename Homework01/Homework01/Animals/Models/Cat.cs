using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Cat : Animal, ICat
    {
        public string Prede {get;set;}
        public Cat(string name, int age, string prede) : base(name, age)
        {
            Prede = prede;
        }
        public void Eat(string food)
        {
            Console.WriteLine($" {Name} is eating {food}.");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is a cat named {Name} who is {Age} years old.");
        }

       
    }
}
