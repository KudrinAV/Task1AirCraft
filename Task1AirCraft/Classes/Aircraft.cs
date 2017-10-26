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

        public double ConsumptionOfFuel { get; private set; }

        public AircraftProperties aircraftProperties { get; private set; }

        public Aircraft(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_)
        {
            TypeOfPlane = typeOfPlane;
            NameOfPlane = nameOfPlane;
            aircraftProperties = aircraftProperties_;
            ConsumptionOfFuel = GetConsumptionOfFuel(aircraftProperties_.RangeOfFlight, aircraftProperties_.CarryingCapacity);
        }

        public double GetConsumptionOfFuel(double RangeOfFlight, double CarryingCapacity )
        {
            return RangeOfFlight * CarryingCapacity;
        }
    }
}
