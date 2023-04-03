using Carss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss.Interfaces
{
    internal interface IGasPump
    {
        void PumpGas(Vehicle vehicle);
    }
}
