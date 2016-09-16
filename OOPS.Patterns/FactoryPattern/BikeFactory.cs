using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern
{
    public class BikeFactory : ITwoWheelerFactory
    {
        public ITwoWheeler CreateVehicle()
        {
            return new Bike();
        }
    }
}
