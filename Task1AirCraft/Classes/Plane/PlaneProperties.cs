using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes.Plane
{
    public struct PlaneProperties
    {
        public string TypeOfEngine;
        public int NumberOfEngines;
        public int NumberOfPilots;
        public int NumberOfWings;
        public int AccelerationLine;

        public PlaneProperties(string typeOfEngine, int numberOfEngines, int numberOfPilots, int numberOfWings, int accelerationLine)
        {
            TypeOfEngine = typeOfEngine;
            NumberOfEngines = numberOfEngines;
            NumberOfPilots = numberOfPilots;
            NumberOfWings = numberOfWings;
            AccelerationLine = accelerationLine;
        }
    }
}
