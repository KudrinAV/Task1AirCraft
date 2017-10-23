using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class TransportHelicopter : Helicopter, ITransport
    {
        public double Power { get; private set; }

        public TransportHelicopter(string type, int minimumHeightOfWork, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight, double power) : base(type, minimumHeightOfWork, carryingCapacity, consumptionOfFire, capacity, rangeOfFlight)
        {
            Power = power;
        }

    }
}
