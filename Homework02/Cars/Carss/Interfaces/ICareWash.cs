using Carss.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss.Interfaces
{
    public interface ICareWash
    {
        void WashCar(Car car);
        void WashTruck(Truck truck);
    }
}
