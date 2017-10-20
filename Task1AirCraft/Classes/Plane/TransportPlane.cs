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
        public TransportPlane(string type, int numberOfEngines, int numberOfPilots, int numberOfWings, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight, double friegtCost, double power) : base(type, numberOfEngines, numberOfPilots, numberOfWings, carryingCapacity, consumptionOfFire, capacity, rangeOfFlight)
        {
            Power = power;
            FreigtCost = friegtCost;
        }

        public double Power { get; private set; }

        public double FreigtCost { get; private set; }
    }
}
