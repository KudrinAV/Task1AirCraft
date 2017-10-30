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

        public PassengerPlane(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, PlanePropertiesModel planeProperties, int numberOfPlaces ) : base(typeOfPlane, nameOfPlane, aircraftProperties, planeProperties)
        {
            NumberOfPlaces = numberOfPlaces;
        }

        public override double GetConsumptionOfFuel()
        {
            return PlaneProperties.NumberOfEngines * AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * 0.007 / NumberOfPlaces;
        }
    }
}
