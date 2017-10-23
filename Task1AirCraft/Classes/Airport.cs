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
        private ICollection<IAircraft> _airport = new List<IAircraft>();

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
            double totalCapacity = 0.0;
            foreach(IAircraft item in _airport)
            {
                totalCapacity += item.Capacity;
            }
            return totalCapacity;
        }

        public double GetTotalCarryingCapacity()
        {
            double totalCarryingCapacity = 0.0;
            foreach(IAircraft item in _airport)
            {
                totalCarryingCapacity += item.CarryingCapacity;
            }
            return totalCarryingCapacity;
        }

        public ICollection<IAircraft> FindAircraftByConsumptionOfFire(double min, double max)
        {
            ICollection<IAircraft> foundAircaft = new List<IAircraft>();
            //var 
            foreach(IAircraft item in _airport)
            {
                if((item.ConsumptionOfFire.CompareTo(min) == 1 && item.ConsumptionOfFire.CompareTo(max) == -1) || item.ConsumptionOfFire.CompareTo(min)==0 || item.ConsumptionOfFire.CompareTo(max)==0)

                {
                    foundAircaft.Add(item);
                }
            }
            return foundAircaft;
        }

        public void SortByFlyingRangeAsc()
        {
            var sorting = _airport.OrderBy(i => i.RangeOfFlight);
            foreach(IAircraft item in sorting)
            {
                Console.WriteLine(item.Type);
            }
        }

        public void SortByFlyingRangeDes()
        {
            var sorting = _airport.OrderByDescending(i => i.RangeOfFlight);
            foreach (IAircraft item in sorting)
            {
                Console.WriteLine(item.Type);
            }
        }
    }
}
