

namespace Homeworks.Models
{
    public class Bike : Vehicle 
    {

        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine("Bike: Year of Production {0}, Color {1}", YearOfProduction, Color);
        }

    }
}
