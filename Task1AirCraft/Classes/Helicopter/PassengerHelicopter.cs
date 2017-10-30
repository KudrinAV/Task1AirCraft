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

        public PassengerHelicopter(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, HelicopterPropertiesModel helicopterProperties, int numberOfPlaces) : base(typeOfPlane, nameOfPlane, aircraftProperties, helicopterProperties)
        {
            NumberOfPlaces = numberOfPlaces;
        }

        public override double GetConsumptionOfFuel()
        {
            return HelicopterProperties.NumberOfScrews * AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * 0.0003 / NumberOfPlaces;
        }
    }
}
