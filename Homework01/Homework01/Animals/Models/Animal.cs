using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
       

        public Animal()
        {

        } 

        public Animal(string name, int age)
        {
            Name = name;    
            Age = age;
         
        }

        

        public abstract void PrintAnimal();
    }
}
