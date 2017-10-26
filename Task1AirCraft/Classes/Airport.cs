using System;
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

        public IEnumerable<double> GetTotatlCapacity()
        {
            var finding = _airport.Select(i => i.aircraftProperties.Capacity);
            return finding;
        }

        public IEnumerable<double> GetTotalCarryingCapacity()
        {
            var finding = _airport.Select(i => i.aircraftProperties.CarryingCapacity);
            return finding;
        }

        public IEnumerable<IAircraft> FindAircraftByConsumptionOfFuel(double min, double max)
        {
            var finding = _airport.Where(i => i.ConsumptionOfFuel <= max && i.ConsumptionOfFuel >= min);
            return finding;
        }

        public IEnumerable<IAircraft> SortByFlyingRangeAsc()
        {
            var sorting = _airport.OrderBy(i => i.aircraftProperties.RangeOfFlight);
            return sorting;
        }

        public IEnumerable<IAircraft> SortByFlyingRangeDes()
        {
            var sorting = _airport.OrderByDescending(i => i.aircraftProperties.RangeOfFlight);
            return sorting;
        }
    }
}
