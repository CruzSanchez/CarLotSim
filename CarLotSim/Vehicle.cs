using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSim
{
    public abstract class Vehicle
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public abstract void Print();
    }
}
