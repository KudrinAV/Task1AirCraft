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
        public PlaneProperties planeProperties { get; private set; }

        public Plane(string typeOfPlane, string nameOfPlane, AircraftProperties aircraftProperties_, PlaneProperties planeProperties_) : base(typeOfPlane, nameOfPlane, aircraftProperties_)
        {
            planeProperties = planeProperties_;
        }
    }
}
