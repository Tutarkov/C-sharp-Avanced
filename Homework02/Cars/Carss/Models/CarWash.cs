using Carss.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss.Models
{
    public class CarWash : ICareWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("Washing a car");
        }

        public void WashTruck(Truck truck)
        {
            Console.WriteLine("Washing a truck");
        }
    }
}
