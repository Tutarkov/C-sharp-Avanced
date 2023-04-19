using Homeworks.Models;
using Homeworks.Static;

static void Main(string[] args)
{
    foreach (var vehicle in DB.Vehicles)
    {
        vehicle.PrintVehicle();
    }

    var car = new Car { Id = 4, Type = "Hatchback", YearsOfProduction = 2021, BatchNumber = 101, FuelTank = 40, CountriesOfProduction = new string[] { "Germany", "France" } };
    Validator.Validate(car);

    var bike = new Bike { Id = 5, Type = "Cruiser", YearsOfProduction = 2022, BatchNumber = 202, Color = "Blue" };
    Validator.Validate(bike);
}
