using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSim
{
    class Car : Vehicle
    {
        public string Honk { get; set; }

        public static int NumOfCars { get; set; } = 0;

        public Car(string _name, int _year, string _honk)
        {
            Name = _name;
            Year = _year;
            Honk = _honk;
            NumOfCars++;
        }

        public override void Print()
        {
            Console.WriteLine("The model of the car is " + Name);
            Console.WriteLine();
            Console.WriteLine("The year of the car is " + Year);
            Console.WriteLine();
            Console.WriteLine("The horn makes the sound " + Honk);
            Console.WriteLine();
        }
    }
}
