using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1AirCraft.Classes.Plane;

namespace Task1AirCraft.Interfaces
{
    public interface IPlane 
    {
        PlaneProperties planeProperties { get; }
    }
}
