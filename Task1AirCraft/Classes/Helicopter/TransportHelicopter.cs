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

        public TransportHelicopter(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, HelicopterPropertiesModel helicopterProperties, double power) : base(typeOfPlane, nameOfPlane, aircraftProperties, helicopterProperties)
        {
            Power = power;
        }

        public override double GetConsumptionOfFuel()
        {
            return HelicopterProperties.NumberOfScrews * AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * _сonsumptionFactor * Power;
        }
    }
}
