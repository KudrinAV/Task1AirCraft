﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AirCraft.Interfaces
{
    public interface ITransport
    {
        double Power { get; }
        double FreigtCost { get; } 
    }
}