using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Classes;

namespace Task1AirCraft.Interfaces
{
    public interface IAircraft : ITypeable
    {
        AircraftProperties AircraftProperties_ { get;}

        double GetConsumptionOfFuel();
    }
}
