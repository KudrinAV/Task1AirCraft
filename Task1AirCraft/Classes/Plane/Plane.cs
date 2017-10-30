using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class Plane : Aircraft, IPlane
    {
        public PlanePropertiesModel PlaneProperties { get; private set; }

        protected new double _сonsumptionFactor = 0.007;

        public Plane(string typeOfPlane, string nameOfPlane, AircraftPropertiesModel aircraftProperties, PlanePropertiesModel planeProperties) : base(typeOfPlane, nameOfPlane, aircraftProperties)
        {
            PlaneProperties = planeProperties;
        }

        public override double GetConsumptionOfFuel()
        {
            return PlaneProperties.NumberOfEngines * AircraftProperties.RangeOfFlight * AircraftProperties.CarryingCapacity * _сonsumptionFactor;
        }
    }
}
