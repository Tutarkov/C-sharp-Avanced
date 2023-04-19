using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FishStore : PetStore<Fish>
    {
        public FishStore()
        {
            AddPet(new Fish { Name = "Nemo", Age = 2, Color = "Orange", Size = "Small" });
            AddPet(new Fish { Name = "Dory", Age = 1, Color = "Blue", Size = "Medium" });
        }
    }
}
