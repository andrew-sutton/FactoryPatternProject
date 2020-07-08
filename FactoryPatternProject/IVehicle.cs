using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternProject
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public void Drive();
    }
}
