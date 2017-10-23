using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class PassengerHelicopter : Helicopter, IPassenger
    {
        public int NumberOfPlaces { get; private set; }

        public PassengerHelicopter(string type, int minimumHeightOfWork, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight, int numberOfPlaces) : base(type, minimumHeightOfWork, carryingCapacity, consumptionOfFire, capacity, rangeOfFlight)
        {
            NumberOfPlaces = numberOfPlaces;
        }
    }
}
