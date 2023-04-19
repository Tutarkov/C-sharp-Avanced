
using Homeworks.Models;

namespace Homeworks.Static
{
    public static class DB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Car() { Id = 1, Type = "sedan", YearOfProduction = 2019, FuelTank = 60, CountriesProducedIn = new List<string>() { "USA", "Germany" } },
            new Bike() { Id = 2, Type = "mountain", YearOfProduction = 2020, Color = "red" },
            new Vehicle() { Id = 3, Type = "truck", YearOfProduction = 2018 }
        };
    }
    }
