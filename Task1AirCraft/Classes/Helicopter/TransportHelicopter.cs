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

        public TransportHelicopter(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, HelicopterPropertiesModel helicopterProperties_, double power) : base(typeOfPlane, nameOfPlane, aircraftProperties_, helicopterProperties_)
        {
            Power = power;
        }

        public override double GetConsumptionOfFuel()
        {
            return HelicopterProperties.NumberOfScrews * AircraftProperties_.RangeOfFlight * AircraftProperties_.CarryingCapacity * 0.0003 * Power;
        }
    }
}
