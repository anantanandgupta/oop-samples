﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.Patterns.FactoryPattern.Base;
using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern
{
    public class ScooterFactory : TwoWheelerFactory
    {
        public override ITwoWheeler CreateVehicle()
        {
            return new Scooter();
        }
    }
}
