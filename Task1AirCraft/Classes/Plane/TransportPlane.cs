using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class TransportPlane : Plane, ITransport
    {
        public double Power { get; private set; }

        public TransportPlane(string type, int numberOfEngines, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight, double power) : base(type, numberOfEngines, carryingCapacity, consumptionOfFire, capacity, rangeOfFlight)
        {
            Power = power;
        }
    }
}
