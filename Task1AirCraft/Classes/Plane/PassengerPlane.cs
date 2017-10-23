using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class PassengerPlane : Plane, IPassenger
    {
        public int NumberOfPlaces { get; private set; }

        public PassengerPlane(string type, int numberOfEngines, double carryingCapacity, double consumptionOfFire, double capacity, double rangeOfFlight, int numberOfPlaces) : base(type, numberOfEngines, carryingCapacity, consumptionOfFire, capacity, rangeOfFlight)
        {
            NumberOfPlaces = numberOfPlaces;
        }
    }
}
