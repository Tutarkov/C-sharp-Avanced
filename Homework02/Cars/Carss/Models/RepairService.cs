using Carss.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checking a vehicle");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing a vehicle"); 
        }
    }
}
