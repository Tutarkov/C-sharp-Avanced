using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Dog : Animal, IDog
    {
        public string Speak { get; set; }

        public Dog(string name, int age, string speak) : base(name, age)
        {
            Speak=speak;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"This is a dog named {Name} who is {Age} years old.");
        }

        public void Bark()
        {
            Console.WriteLine($"The dog sppeak {Speak}.");
        }


    }
}
