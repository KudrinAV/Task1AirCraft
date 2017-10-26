using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class PassengerPlane : Plane, IPassenger
    {
        public int NumberOfPlaces { get; private set; }

        public PassengerPlane(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, PlaneProperties planeProperties_, int numberOfPlaces ) : base(typeOfPlane, nameOfPlane, aircraftProperties_, planeProperties_)
        {
            NumberOfPlaces = numberOfPlaces;
        }
    }
}
