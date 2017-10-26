using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class PassengerHelicopter : Helicopter, IPassenger
    {
        public int NumberOfPlaces { get; private set; }

        public PassengerHelicopter(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, HelicopterProperties helicopterProperties_, int numberOfPlaces) : base(typeOfPlane, nameOfPlane, aircraftProperties_, helicopterProperties_)
        {
            NumberOfPlaces = numberOfPlaces;
        }
        
    }
}
