using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes
{
    public struct AircraftProperties
    {
        public double CarryingCapacity ;
        public double RangeOfFlight;
        public double Capacity;

        public AircraftProperties (double carryingCapacity, double capacity, double rangeOfFlight)
        {
            CarryingCapacity = carryingCapacity;
            RangeOfFlight = rangeOfFlight;
            Capacity = capacity;
        }
    }
}
