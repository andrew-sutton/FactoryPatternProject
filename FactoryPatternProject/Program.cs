using System;
using System.Threading;

namespace FactoryPatternProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What vehicle do you want to build? Give me the number of wheels");
            var numWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Building your new vehicle...");
            var vehicle = VehicleFactory.CreateVehicle(numWheels);
            Thread.Sleep(2000);
            Console.WriteLine($"Congrats on your new {vehicle.Name}!");
            Console.ReadKey();
            vehicle.Drive();
        }
    }
}
