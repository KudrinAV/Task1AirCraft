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
        public PlaneProperties PlaneProperties_ { get; private set; }

        public Plane(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, PlaneProperties planeProperties_) : base(typeOfPlane, nameOfPlane, aircraftProperties_)
        {
            PlaneProperties_ = planeProperties_;
        }

        public override double GetConsumptionOfFuel()
        {
            return PlaneProperties_.NumberOfEngines * AircraftProperties_.RangeOfFlight * AircraftProperties_.CarryingCapacity * 0.007;
        }
    }
}
