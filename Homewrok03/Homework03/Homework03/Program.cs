using Homeworks.Models;
using Homeworks.Static;
namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Vehicle vehicle in DB.Vehicles)
            {
                vehicle.PrintVehicle();
            }

            Car carToValidate = new Car() { Id = 0, Type = "", YearOfProduction = 2015 };
            Bike bikeToValidate = new Bike() { Id = 4, Type = "road", YearOfProduction = 0, Color = "blue" };

            Console.WriteLine("Car validation result: {0}", Validator.Validate(carToValidate));
            Console.WriteLine("Bike validation result: {0}", Validator.Validate(bikeToValidate));

            Console.ReadLine();
        }
    }
}
