﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes
{
    public class Airport : ICollection<IAircraft>
    {
        private ICollection<IAircraft> _airport;

        public Airport(ICollection<IAircraft> airport)
        {
            _airport = airport;
        }

        public int Count { get { return _airport.Count; } }

        public bool IsReadOnly { get { return _airport.IsReadOnly; } }

        public void Add(IAircraft item)
        {
            _airport.Add(item);
        }

        public void Clear()
        {
            _airport.Clear();
        }

        public bool Contains(IAircraft item)
        {
            return _airport.Contains(item);
        }

        public void CopyTo(IAircraft[] array, int arrayIndex)
        {
            _airport.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IAircraft> GetEnumerator()
        {
            return _airport.GetEnumerator();
        }

        public bool Remove(IAircraft item)
        {
            return _airport.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _airport.GetEnumerator();
        }

        public double GetTotatlCapacity()
        {
            double TotalCapacity = 0.0;
            var finding = _airport.Select(i => i.AircraftProperties.Capacity);
            foreach(var item in finding)
            {
                TotalCapacity += item;
            }
            return TotalCapacity;
        }

        public double GetTotalCarryingCapacity()
        {
            double TotalCarryingCapacity = 0.0;
            var finding = _airport.Select(i => i.AircraftProperties.CarryingCapacity);
            foreach (var item in finding)
            {
                TotalCarryingCapacity += item;
            }
            return TotalCarryingCapacity;
        }

        public IEnumerable<IAircraft> GetFindAircraftByConsumptionOfFuel(double min, double max)
        {
            var finding = from item in _airport
                          let i = item.GetConsumptionOfFuel()
                          where (i >= min && i <= max)
                          select item;    
            return finding;
        }

        public IEnumerable<IAircraft> GetSortByFlyingRangeAsc()
        {
            var sorting = _airport.OrderBy(i => i.AircraftProperties.RangeOfFlight);
            return sorting;
        }

        public IEnumerable<IAircraft> GetSortByFlyingRangeDes()
        {
            var sorting = _airport.OrderByDescending(i => i.AircraftProperties.RangeOfFlight);
            return sorting;
        }
    }
}
