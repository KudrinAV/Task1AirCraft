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

        public double ConsumptionOfFuel { get; protected set; }

        public AircraftProperties AircraftProperties_ { get; private set; }

        public Aircraft(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_)
        {
            TypeOfPlane = typeOfPlane;
            NameOfPlane = nameOfPlane;
            AircraftProperties_ = aircraftProperties_;
        }

        public virtual double GetConsumptionOfFuel()
        {
            return AircraftProperties_.RangeOfFlight * AircraftProperties_.CarryingCapacity/1000;
        }
    }
}
