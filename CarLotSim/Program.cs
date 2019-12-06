using System;

namespace CarLotSim
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot() { Name = "Big Boss' Shit With Tires Emporium" };
            lot.Welcome();

            Console.WriteLine("The car and truck lot is up first! Press ENTER to move to the next vehicle!");
            Console.ReadKey();
            Console.WriteLine();

            Car fiesta = new Car("Ford Fiesta", 2014, "Honk!");
            lot.Cars.Add(fiesta);

            Car ram = new Car("Dodge Ram", 2001, "OOOOOGGGGAAAA!!!");
            lot.Cars.Add(ram);

            Car ranger = new Car("Ford Ranger", 1996, "honk...");
            lot.Cars.Add(ranger);

            lot.LoopVehicle(lot.Cars);

            Console.WriteLine("The motorcycles are up next!");
            Console.ReadKey();
            Console.WriteLine();

            Motorcycle honda = new Motorcycle("Honda Shadow", 1999, "BRRRUMMM!");
            lot.Bikes.Add(honda);

            Motorcycle harley = new Motorcycle("Harley Davidson", 2019, "Bumbumbmubum");
            lot.Bikes.Add(harley);

            Motorcycle kawasaki = new Motorcycle("Kawasaki Ninja", 2007, "RIIIIIIIIII");
            lot.Bikes.Add(kawasaki);

            lot.LoopVehicle(lot.Bikes);

            lot.Print(Car.NumOfCars, Motorcycle.NumOfBikes);
            Console.WriteLine("Press ENTER to exit!");
            Console.ReadKey();

        }
    }
}
