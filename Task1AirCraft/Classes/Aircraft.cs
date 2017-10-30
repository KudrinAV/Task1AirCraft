using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes
{
    public class Aircraft : ITypeable, IAircraft 
    {
        public string TypeOfPlane { get; private set; }

        public string NameOfPlane { get; private set; }

        protected double _сonsumptionFactor = 0.001;

        public AircraftPropertiesModel AircraftProperties { get; private set; }

        public Aircraft(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties)
        {
            TypeOfPlane = typeOfPlane;
            NameOfPlane = nameOfPlane;
            AircraftProperties = aircraftProperties;
        }

        public virtual double GetConsumptionOfFuel()
        {
            return AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * _сonsumptionFactor;
        }
    }
}
