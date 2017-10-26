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

        public PlaneProperties(string typeOfEngine, int numberOfEngines, int numberOfPilots, int numberOfWings)
        {
            TypeOfEngine = typeOfEngine;
            NumberOfEngines = numberOfEngines;
            NumberOfPilots = numberOfPilots;
            NumberOfWings = numberOfWings;
        }
    }
}
