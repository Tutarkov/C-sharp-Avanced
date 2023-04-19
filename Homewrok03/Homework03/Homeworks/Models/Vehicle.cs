

namespace Homeworks.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine("Vehicle: {0}, Type: {1}, Year of Production: {2}", Id, Type, YearOfProduction);
        }
    }
}
