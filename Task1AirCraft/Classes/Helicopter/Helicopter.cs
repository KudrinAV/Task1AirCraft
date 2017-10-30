using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class Helicopter : Aircraft, IHelicopter
    {
        public HelicopterPropertiesModel HelicopterProperties { get; private set; }

        public Helicopter(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, HelicopterPropertiesModel helicopterProperties) : base(typeOfPlane, nameOfPlane, aircraftProperties)
        {
            HelicopterProperties = helicopterProperties;
        }

        public override double GetConsumptionOfFuel()
        {
            return HelicopterProperties.NumberOfScrews* AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * 0.0003;
        }
    }
}
