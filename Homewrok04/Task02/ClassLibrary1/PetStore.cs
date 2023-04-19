using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PetStore<T> where T : Pet
    {
        private List<T> pets = new List<T>();

        public void AddPet(T pet)
        {
            pets.Add(pet);
        }

        public void PrintPets()
        {
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T petToRemove = pets.Find(p => p.Name == name);

            if (petToRemove != null)
            {
                pets.Remove(petToRemove);
                Console.WriteLine($"You bought {petToRemove.Name}!");
            }
            else
            {
                Console.WriteLine($"There is no pet named {name}.");
            }
        }
    }
}
