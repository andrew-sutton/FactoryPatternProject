using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternProject
{
    class Car : IVehicle
    {
        public Car()
        {
            Name = "Car";
        }
        public string Name { get; set; }
        public void Drive()
        {
            Console.WriteLine("The Car drives");
        }
    }
}
