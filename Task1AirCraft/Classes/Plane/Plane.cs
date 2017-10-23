using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class Plane : Aircraft, IPlane
    {
        public int NumberOfEngines { get; protected set; }

        public double CarryingCapacity { get; protected set; }

        public double ConsumptionOfFire { get; protected set; }

        public double Capacity { get; protected set; }

        public double RangeOfFlight { get; protected set; }

        public Plane(string type, int numberOfEngines, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight) : base(type)
        {
            NumberOfEngines = numberOfEngines;
            CarryingCapacity = carryingCapacity;
            ConsumptionOfFire = consumptionOfFire;
            Capacity = capacity;
            RangeOfFlight = rangeOfFlight;
        }
    }
}
