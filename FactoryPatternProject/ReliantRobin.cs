using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternProject
{
    class ReliantRobin : IVehicle
    {
        public ReliantRobin()
        {
            Name = "Reliant Robin";
        }
        public string Name { get; set; }
        public void Drive()
        {
            Console.WriteLine("The Reliant robin drives, then tips over");
        }
    }
}
