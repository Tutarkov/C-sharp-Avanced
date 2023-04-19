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
        public List<string> CountriesOfProduction { get; set; }

        public Car(int id, string type, int yearsOfProduction, int batchNumber, int fuelTank, List<string> CountriesOfProduction ) : base(id, type, yearsOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Car is with  {YearsOfProduction} YearOfProduction and is producted {CountriesOfProduction}");
        }

    }
}
