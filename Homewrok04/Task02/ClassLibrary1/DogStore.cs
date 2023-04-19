using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DogStore : PetStore<Dog>
    {
        public DogStore()
        {
            AddPet(new Dog { Name = "Buddy", Age = 3, FavoriteFood = "Beef" });
            AddPet(new Dog { Name = "Rocky", Age = 2, FavoriteFood = "Chicken" });
        }
    }
}
