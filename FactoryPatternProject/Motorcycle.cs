using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternProject
{
    class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Name = "Motorcycle";
        }
    public string Name { get; set; }
    public void Drive()
        {
            Console.WriteLine("The Motorcycle drives");
        }
    }
}
