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

        public Plane(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, PlanePropertiesModel planeProperties) : base(typeOfPlane, nameOfPlane, aircraftProperties_)
        {
            PlaneProperties = planeProperties;
        }

        public override double GetConsumptionOfFuel()
        {
            return PlaneProperties.NumberOfEngines * AircraftProperties_.RangeOfFlight * AircraftProperties_.CarryingCapacity * 0.007;
        }
    }
}
