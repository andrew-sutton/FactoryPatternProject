using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternProject
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(int numWheels)
        {
            switch (numWheels)
            {
                case 4:
                    return new Car();
                case 3:
                    return new ReliantRobin();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
