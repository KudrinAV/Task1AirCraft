using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Interfaces;

namespace Task1AirCraft.Classes
{
    public class Aircraft : ITypeable
    {
        public string Type { get; }

        public Aircraft(string type)
        {
            Type = type;
        }
    }
}
