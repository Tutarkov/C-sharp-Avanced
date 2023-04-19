using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CatStore : PetStore<Cat>
    {
        public CatStore()
        {
            AddPet(new Cat { Name = "Garfield", Age = 5, Lazy = true, LivesLeft = 8 });
            AddPet(new Cat { Name = "Whiskers", Age = 1, Lazy = false, LivesLeft = 9 });
        }
    }
}
