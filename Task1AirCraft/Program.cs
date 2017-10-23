using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Classes;
using Task1AirCraft.Classes.Helicopter;
using Task1AirCraft.Classes.Plane;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            IAircraft plane1 = new Plane(type: "Boing1", numberOfEngines: 3, carryingCapacity: 320.2, consumptionOfFire: 240, capacity: 120, rangeOfFlight: 3000);
            IAircraft plane2 = new Plane(type: "Boing2", numberOfEngines: 5, carryingCapacity: 380.2, consumptionOfFire: 120, capacity: 150, rangeOfFlight: 3500);
            IAircraft plane3 = new Plane(type: "Boing3", numberOfEngines: 4, carryingCapacity: 240.2, consumptionOfFire: 60, capacity: 130, rangeOfFlight: 2000);
            IAircraft plane4 = new Plane(type: "Boing4", numberOfEngines: 2, carryingCapacity: 720.2, consumptionOfFire: 230, capacity: 140, rangeOfFlight: 1500);

            Airport testAiport = new Airport();
            testAiport.Add(plane1);
            testAiport.Add(plane2);
            testAiport.Add(plane3);
            testAiport.Add(plane4);

            Console.WriteLine(testAiport.GetTotatlCapacity());
            Console.WriteLine(testAiport.GetTotalCarryingCapacity());
            foreach(var item in testAiport.FindAircraftByConsumptionOfFire(60, 230))
            {
                Console.WriteLine(item.Type);
            }
            //testAiport.SortByFlyingRangeDes();
            //testAiport.SortByFlyingRangeAsc();
        }
    }
}
