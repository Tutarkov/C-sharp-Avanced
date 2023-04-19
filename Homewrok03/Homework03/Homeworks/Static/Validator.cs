

using Homeworks.Models;

namespace Homeworks.Static
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0)
                Console.WriteLine("Invalid Id");
            if (string.IsNullOrEmpty(vehicle.Type))
                Console.WriteLine("Invalid Type");
            if (vehicle.YearsOfProduction == 0)
                Console.WriteLine("Invalid Year of Production");
        }
    }
}
