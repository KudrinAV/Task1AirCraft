using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes.Helicopter
{
    public struct HelicopterPropertiesModel
    {
        public int MinimumHeightOfWork;
        public int MaximumHeightOfwork;
        public int NumberOfScrews;

        public HelicopterPropertiesModel(int maximumHeightOfWork, int minimumHeightOfWork, int numberOfScrews)
        {
            MinimumHeightOfWork = minimumHeightOfWork;
            MaximumHeightOfwork = maximumHeightOfWork;
            NumberOfScrews = numberOfScrews;
        }

    }
}
