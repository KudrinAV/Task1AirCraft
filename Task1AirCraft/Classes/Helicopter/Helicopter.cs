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
        public HelicopterProperties HelicopterProperties_ { get; private set; }

        public Helicopter(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, HelicopterProperties helicopterProperties_) : base(typeOfPlane, nameOfPlane, aircraftProperties_)
        {
            HelicopterProperties_ = helicopterProperties_;
        }

        public override double GetConsumptionOfFuel()
        {
            return HelicopterProperties_.NumberOfScrews* AircraftProperties_.RangeOfFlight * AircraftProperties_.CarryingCapacity * 0.0007;
        }
    }
}
