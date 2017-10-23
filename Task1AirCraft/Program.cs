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
            IAircraft plane1 = new Plane("Boing1", 3, 320.2, 240, 120, 3000);
            IAircraft plane2 = new Plane("Boing2", 5, 380.2, 120, 150, 3500);
            IAircraft plane3 = new Plane("Boing3", 4, 240.2, 60, 130, 2000);
            IAircraft plane4 = new Plane("Boing4", 2, 720.2, 230, 140, 1500);

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
        }
    }
}
