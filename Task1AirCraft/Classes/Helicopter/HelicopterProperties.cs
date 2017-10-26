using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Classes.Helicopter
{
    public struct HelicopterProperties
    {
        int MinimumHeightOfWork;
        int MaximumHeightOfwork;
        int NumberOfScrews;

        public HelicopterProperties(int maximumHeightOfWork, int minimumHeightOfWork, int nymberOfScrews)
        {
            MinimumHeightOfWork = minimumHeightOfWork;
            MaximumHeightOfwork = maximumHeightOfWork;
            NumberOfScrews = nymberOfScrews;
        }

    }
}
