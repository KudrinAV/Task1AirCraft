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
        public static ICollection<IAircraft> GetListAircraft()
        {
            AircraftProperties aircraftProperties = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 5000);
            AircraftProperties aircraftProperties1 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 4000);
            AircraftProperties aircraftProperties2 = new AircraftProperties(capacity: 200, carryingCapacity: 500, rangeOfFlight: 3000);
            PlanePropertiesModel planeProperties = new PlanePropertiesModel(numberOfEngines: 2, numberOfPilots: 2, accelerationLine: 500);
            HelicopterPropertiesModel helicopterProperties = new HelicopterPropertiesModel(maximumHeightOfWork: 300, minimumHeightOfWork: 50, numberOfScrews: 4);

            List<IAircraft> airport = new List<IAircraft>() {
                new Aircraft("Original", "Original", aircraftProperties),
                new Plane(typeOfPlane: "boing1", nameOfPlane: "Alice", aircraftProperties_: aircraftProperties, planeProperties: planeProperties),
                new PassengerPlane(typeOfPlane: "boing2", nameOfPlane: "Orianna", aircraftProperties_: aircraftProperties1, planeProperties_: planeProperties, numberOfPlaces: 120),
                new TransportPlane(typeOfPlane: "boing2", nameOfPlane: "TwoBe", aircraftProperties_: aircraftProperties2, planeProperties_: planeProperties, power: 20),
                new Helicopter(typeOfPlane: "Ansat1", nameOfPlane: "NineS", aircraftProperties_: aircraftProperties1, helicopterProperties: helicopterProperties),
                new PassengerHelicopter(typeOfPlane: "Ansat2", nameOfPlane: "ATwo", aircraftProperties_: aircraftProperties, helicopterProperties_: helicopterProperties, numberOfPlaces: 30),
                new TransportHelicopter(typeOfPlane: "Ansat3", nameOfPlane: "Nier", aircraftProperties_: aircraftProperties2, helicopterProperties_: helicopterProperties, power: 5)
            };
            return airport;
        }

        public static void ShowAllAircraft(Airport airport)
        {
            Console.WriteLine("Все экземпляры.");
            Console.WriteLine($"|{"Название",-10}|{"Дистанция полета",-20}|{"Переносимый груз",-20}|{"Вместимость груза",-20}|{"Потребление горючего",20}|");
            foreach (var item in airport)
            {
                Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", item.NameOfPlane, item.AircraftProperties_.RangeOfFlight, item.AircraftProperties_.CarryingCapacity, item.AircraftProperties_.Capacity, item.GetConsumptionOfFuel());
            }
        }

        public static void ShowGetAllMethods(Airport airport)
        {
            Console.WriteLine("Результаты методов полного подсчета.");
            Console.WriteLine("Общая вместимость груза: " + airport.GetTotalCarryingCapacity());
            Console.WriteLine("Общая вместимость : " + airport.GetTotatlCapacity());
        }

        public static void ShowGetFindByConmsumptionOfFuel(Airport airport)
        {
            Console.WriteLine("Демонстрация фильтрации по параметрам горючего.");
            Console.WriteLine("Мин значение потребляемого горючего: 35000");
            Console.WriteLine("Макс значение потребляемого горючего: 1000000");
            Console.WriteLine("|{0,-10}|{1,-20}|", "Название", "Потребление горючего");
            foreach (var item in airport.GetFindAircraftByConsumptionOfFuel(35000, 1000000))
            {
                Console.WriteLine("|{0,-10}|{1,-20}|", item.NameOfPlane, item.GetConsumptionOfFuel());
            }
        }

        public static void ShowGetOrderBy(Airport airport)
        {
            Console.WriteLine("Демонстрация сортировки по возрастанию");
            Console.WriteLine("|{0,-10}|{1,-20}|", "Название", "Длина полета");
            foreach (var item in airport.GetSortByFlyingRangeAsc())
            {
                Console.WriteLine("|{0,-10}|{1,-20}|", item.NameOfPlane, item.AircraftProperties_.RangeOfFlight);
            }
            Console.WriteLine("\nДемонстрация сортировки по убывания");
            Console.WriteLine("|{0,-10}|{1,-20}|", "Название", "Длина полета");
            foreach (var item in airport.GetSortByFlyingRangeDes())
            {
                Console.WriteLine("|{0,-10}|{1,-20}|", item.NameOfPlane, item.AircraftProperties_.RangeOfFlight);
            }
        }

        static void Main(string[] args)
        {
            Airport airport = new Airport(GetListAircraft());

            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------\n");
            ShowAllAircraft(airport);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------\n");
            ShowGetAllMethods(airport);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------\n");
            ShowGetFindByConmsumptionOfFuel(airport);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------\n");
            ShowGetOrderBy(airport);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------\n");


        }
    }
}
