using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSim
{
    class CarLot
    {
        public string Name { get; set; }

        public int TotalCars { get; set; }

        public int TotalBikes { get; set; }

        public List<Vehicle> Cars = new List<Vehicle>();

        public List<Vehicle> Bikes = new List<Vehicle>();

        public void LoopVehicle(List<Vehicle> vehicleList)
        {
            foreach (Vehicle vehicle in vehicleList)
            {
                vehicle.Print();
                Console.ReadLine();
            }
        }

        //public void LoopBikes(List<Motorcycle> bikeList)
        //{
        //    foreach (Motorcycle bike in bikeList)
        //    {
        //        bike.Print();
        //        Console.ReadLine();
        //    }
        //}

        public void Welcome()
        {
            Console.WriteLine("Welcome to " + Name + "! I'll give you a tour!");
        }

        public void Print(int numOfCars, int numOfBikes)
        {
            Console.WriteLine("We have " + numOfCars + " cars and " + numOfBikes + " bikes here at " + Name + "!");
        }
    }
}
