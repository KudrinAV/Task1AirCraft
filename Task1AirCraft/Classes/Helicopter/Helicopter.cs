using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class Helicopter : Aircraft, IHelicopter
    {
        public int MinimumHeightOfWork { get; protected set; }

        public int MaximumHeightOfWork { get; protected set; }

        public double CarryingCapacity { get; protected set; }

        public double ConsumptionOfFire { get; protected set; }

        public double Capacity { get; protected set; }

        public double RangeOfFlight { get; protected set; }

        public Helicopter(string type, int minimumHeightOfWork, int maximumHeightOfWork, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight) : base(type)
        {
            MinimumHeightOfWork = minimumHeightOfWork;
            MaximumHeightOfWork = maximumHeightOfWork;
            CarryingCapacity = carryingCapacity;
            ConsumptionOfFire = consumptionOfFire;
            Capacity = capacity;
            RangeOfFlight = rangeOfFlight;
        }
    }
}
