
using Homeworks.Models;

namespace Homeworks.Static
{
    public static class DB 
    {
        private static List<Vehicle> vehicles = new List<Vehicle>
    {
        new Car { Id = 1, Type = "Sedan", YearsOfProduction = 2019, BatchNumber = 123, FuelTank = 50, CountriesOfProduction = new string[] { "USA", "Japan" } },
        new Bike { Id = 2, Type = "Sports", YearsOfProduction = 2020, BatchNumber = 456, Color = "Red" },
        new Vehicle { Id = 3, Type = "Truck", YearsOfProduction = 2018, BatchNumber = 789 }
    };

    }
}
