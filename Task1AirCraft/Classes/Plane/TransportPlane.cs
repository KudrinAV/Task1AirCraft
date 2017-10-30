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

        public TransportPlane(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, PlanePropertiesModel planeProperties, double power) : base(typeOfPlane, nameOfPlane, aircraftProperties, planeProperties)
        {
            Power = power;
        }

        public override double GetConsumptionOfFuel()
        {
            return PlaneProperties.NumberOfEngines * AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * 0.007 * Power;
        }
    }
}
