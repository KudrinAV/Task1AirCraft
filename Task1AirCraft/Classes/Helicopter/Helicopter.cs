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
        public HelicopterProperties helicopterProperties { get; private set; }

        public Helicopter(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, HelicopterProperties helicopterProperties_) : base(typeOfPlane, nameOfPlane, aircraftProperties_)
        {
            helicopterProperties = helicopterProperties_;
        }
    }
}
