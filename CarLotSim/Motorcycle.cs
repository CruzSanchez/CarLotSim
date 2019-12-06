using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSim
{
    class Motorcycle : Vehicle
    {
        public string EngineNoise { get; set; }

        public static int NumOfBikes { get; set; } = 0;

        public Motorcycle(string _name, int _year, string _engineNoise)
        {
            Name = _name;
            Year = _year;
            EngineNoise = _engineNoise;
            NumOfBikes++;
        }

        public override void Print()
        {
            Console.WriteLine("The model of the motorcycle is " + Name);
            Console.WriteLine();
            Console.WriteLine("The year of the bike is " + Year);
            Console.WriteLine();
            Console.WriteLine("The engine sounds like " + EngineNoise);
            Console.WriteLine();
        }
    }
}
