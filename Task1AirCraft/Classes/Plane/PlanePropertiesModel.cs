using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes.Plane
{
    public struct PlanePropertiesModel
    {
        public int NumberOfEngines;
        public int NumberOfPilots;
        public int AccelerationLine;

        public PlanePropertiesModel(int numberOfEngines, int numberOfPilots, int accelerationLine)
        {
            NumberOfEngines = numberOfEngines;
            NumberOfPilots = numberOfPilots;
            AccelerationLine = accelerationLine;
        }
    }
}
