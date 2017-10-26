using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Plane
{
    class TransportPlane : Plane, ITransport
    {
        public double Power { get; private set; }

        public TransportPlane(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, PlaneProperties planeProperties_, double power) : base(typeOfPlane, nameOfPlane, aircraftProperties_, planeProperties_)
        {
            Power = power;
        }
    }
}
