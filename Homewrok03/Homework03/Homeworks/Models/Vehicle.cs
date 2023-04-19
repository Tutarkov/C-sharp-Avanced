

namespace Homeworks.Models
{
    public class Vehicle
    {
        public int Id { get; set; } 
        public string Type { get; set; }
        public int YearsOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearsOfProduction,int batchNumber)
        {
            Id = id;    
            Type = type;
            YearsOfProduction = yearsOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Vehicle with ID {Id}, Type {Type} and YearsOfProduction {YearsOfProduction} ");
        }
    }
}
