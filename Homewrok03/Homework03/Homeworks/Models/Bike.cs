

namespace Homeworks.Models
{
    public class Bike : Vehicle 
    {
       
        public string Color { get; set; }

        public Bike(int id, string type, int yearsOfProduction, int batchNumber,string color) : base(id, type, yearsOfProduction, batchNumber)
        {
            Color = color;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Bike with  {YearsOfProduction} YearOfProduction and with {Color} color is for sell ");
        }

    }
}
