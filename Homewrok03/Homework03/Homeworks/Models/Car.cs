using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesProducedIn { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine("Car: Type {0}, Produced in: {1}", Type, string.Join(", ", CountriesProducedIn));
        }

    }
}
