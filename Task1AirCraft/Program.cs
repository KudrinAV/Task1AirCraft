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
            AircraftProperties aircraftProperties0 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);

            AircraftProperties aircraftProperties1 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);
            PlaneProperties planeProperties1 = new PlaneProperties(typeOfEngine: "поршневые", numberOfEngines: 2, numberOfPilots: 2, numberOfWings: 2, accelerationLine: 500);

            AircraftProperties aircraftProperties2 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);
            PlaneProperties planeProperties2 = new PlaneProperties(typeOfEngine: "трубовиновые", numberOfEngines: 2, numberOfPilots: 2, numberOfWings: 2, accelerationLine: 500);

            AircraftProperties aircraftProperties3 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);
            PlaneProperties planeProperties3 = new PlaneProperties(typeOfEngine: "турбореактивные", numberOfEngines: 2, numberOfPilots: 2, numberOfWings: 2, accelerationLine: 500);

            AircraftProperties aircraftProperties4 = new AircraftProperties(capacity: 40, carryingCapacity: 250, rangeOfFlight: 1500);
            PlaneProperties planeProperties4 = new PlaneProperties(typeOfEngine: "с ракетными двигателями", numberOfEngines: 3, numberOfPilots: 2, numberOfWings: 4, accelerationLine: 540);

            AircraftProperties aircraftProperties5 = new AircraftProperties(capacity: 600, carryingCapacity: 310, rangeOfFlight: 5000);
            PlaneProperties planeProperties5 = new PlaneProperties(typeOfEngine: "КСУ", numberOfEngines: 5, numberOfPilots: 2, numberOfWings: 3, accelerationLine: 390);

            AircraftProperties aircraftProperties6 = new AircraftProperties(capacity: 300, carryingCapacity: 520, rangeOfFlight: 5300);
            PlaneProperties planeProperties6 = new PlaneProperties(typeOfEngine: "электрический", numberOfEngines: 1, numberOfPilots: 2, numberOfWings: 3, accelerationLine: 480);


            List<IAircraft> myAirport = new List<IAircraft>();
            Aircraft plane1 = new Plane("boing1", "Alice", aircraftProperties1, planeProperties1);
            Aircraft plane2 = new Plane("boing2", "Orianna", aircraftProperties2, planeProperties2);
            Aircraft plane3 = new Plane("boing3", "2B", aircraftProperties3, planeProperties3);
            Aircraft plane4 = new Plane("boing4", "9S", aircraftProperties4, planeProperties4);
            Aircraft plane5 = new Plane("boing5", "A2", aircraftProperties5, planeProperties5);
            Plane plane6 = new Plane("boing6", "NIER", aircraftProperties6, planeProperties6);

            List<IAircraft> myAirport2 = new List<IAircraft>();

            myAirport.Add(plane1);
            myAirport.Add(plane2);
            myAirport.Add(plane3);
            myAirport.Add(plane4);
            myAirport.Add(plane5);
            myAirport.Add(plane6);

            Airport airport = new Airport(myAirport);

            //foreach (IAircraft item in airport.FindAircraftByConsumptionOfFuel(100, 30000000))
            //{
            //    Console.WriteLine(item.NameOfPlane + " " + item.AircraftProperties_.RangeOfFlight + " " + item.AircraftProperties_.CarryingCapacity + " " + item.GetConsumptionOfFuel());
            //}

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
