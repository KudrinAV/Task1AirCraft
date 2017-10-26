using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes.Plane
{
    public struct PlaneProperties
    {
        string TypeOfEngine;
        int NumberOfEngines;
        int NumberOfPilots;
        int NumberOfWings;
        int AccelerationLine;

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
