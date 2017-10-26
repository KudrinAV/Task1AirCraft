using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes.Helicopter
{
    class TransportHelicopter : Helicopter, ITransport
    {
        public double Power { get; private set; }

        public TransportHelicopter(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, HelicopterProperties helicopterProperties_, double power) : base(typeOfPlane, nameOfPlane, aircraftProperties_, helicopterProperties_)
        {
            Power = power;
        }
    }
}
