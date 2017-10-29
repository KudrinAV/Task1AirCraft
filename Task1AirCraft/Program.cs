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
            AircraftProperties aircraftProperties = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);
            PlaneProperties planeProperties = new PlaneProperties(numberOfEngines: 2, numberOfPilots: 2, accelerationLine: 500);
            HelicopterProperties helicopterProperties = new HelicopterProperties(maximumHeightOfWork: 300, minimumHeightOfWork: 50, numberOfScrews: 4);

            List<IAircraft> myAirport = new List<IAircraft>() {
                new Aircraft("boing1", "Original", aircraftProperties),
                new Plane(typeOfPlane: "boing1", nameOfPlane: "Alice", aircraftProperties_: aircraftProperties, planeProperties_: planeProperties),
                new PassengerPlane(typeOfPlane: "boing2", nameOfPlane: "Orianna", aircraftProperties_: aircraftProperties, planeProperties_: planeProperties, numberOfPlaces: 120),
                new TransportPlane(typeOfPlane: "boing2", nameOfPlane: "TwoBe", aircraftProperties_: aircraftProperties, planeProperties_: planeProperties, power: 20),
                new Helicopter(typeOfPlane: "Ansat1", nameOfPlane: "NineS", aircraftProperties_: aircraftProperties, helicopterProperties_: helicopterProperties),
                new PassengerHelicopter(typeOfPlane: "Ansat2", nameOfPlane: "ATwo", aircraftProperties_: aircraftProperties, helicopterProperties_: helicopterProperties, numberOfPlaces: 30),
                new TransportHelicopter(typeOfPlane: "Ansat3", nameOfPlane: "Nier", aircraftProperties_: aircraftProperties, helicopterProperties_: helicopterProperties, power: 5)
            };
            List<IAircraft> myAirport2 = new List<IAircraft>();

            //myAirport.Add(plane1);
            //myAirport.Add(plane2);
            //myAirport.Add(plane3);
            //myAirport.Add(plane4);
            //myAirport.Add(plane5);
            //myAirport.Add(plane6);

            Airport airport = new Airport(myAirport);

            foreach (IAircraft item in airport.GetFindAircraftByConsumptionOfFuel(30000, 30000000))
            {
                Console.WriteLine(item.NameOfPlane + " " + item.AircraftProperties_.RangeOfFlight + " " + item.AircraftProperties_.CarryingCapacity + " " + item.GetConsumptionOfFuel());
            }

            //double TotalCaryringCapacity = 0.0;
            //foreach(var item in airport.GetTotalCarryingCapacity())
            //{
            //    TotalCaryringCapacity += item;
            //}
            //Console.WriteLine(TotalCaryringCapacity);

            //double TotalCapacity = 0.0;
            //foreach(var item in airport.GetTotatlCapacity())
            //{
            //    TotalCapacity += item;
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(TotalCapacity);
            //Console.WriteLine(testAiport.GetTotatlCapacity());
            //Console.WriteLine(testAiport.GetTotalCarryingCapacity());
            //foreach (var item in testAiport.FindAircraftByConsumptionOfFire(60, 230))
            //{
            //    Console.WriteLine(item.Type);
            //}
            //testAiport.SortByFlyingRangeDes();
            //testAiport.SortByFlyingRangeAsc();
        }
    }
}
