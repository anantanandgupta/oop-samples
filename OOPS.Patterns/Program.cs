using System;
using System.Collections.Generic;
using OOPS.Patterns.FactoryPattern;
using OOPS.Patterns.FactoryPattern.Interfaces;
using OOPS.Patterns.Singleton;

namespace OOPS.Patterns
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ExecuteFactoryPattern();
        }

        private static void ExecuteFactoryPattern()
        {
            var vehicles = new List<IVehicle>();
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new CarFactory()));
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new JeepFactory()));
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new ScooterFactory()));
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new BikeFactory()));
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new JeepFactory()));
            vehicles.Add(VehicleCompany.Instance.ProduceVehicle(new CarFactory()));
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Vehicle " + vehicle.VehecleName + " has " + vehicle.NumberOfWheels + " wheels.");
                Console.WriteLine(vehicle.GetType().FullName);
            }
            Console.ReadLine();
        }
    }
}
