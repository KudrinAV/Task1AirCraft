using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Interfaces
{
    public interface IAircraft
    {
        double CarryingCapacity { get; }
        double ConsumptionOfFire { get; }
        double Capacity { get; }
        double RangeOfFlight { get; } 
    }
}
