
using Animals.Interfaces;
using Animals.Models;
using System.Data.Common;

Dog dog = new Dog("Bak",2,"AUU AUU");
dog.PrintAnimal();
dog.Bark();

Cat cat = new Cat("Maca", 1,"Grrrrr");
cat.PrintAnimal();
cat.Eat("fish");
