using System;
using System.Collections.Generic;
using OOPS.Patterns.FactoryPattern;
using OOPS.Patterns.FactoryPattern.Interfaces;

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
            vehicles.Add(Producer.ProduceVehicle(new CarFactory()));
            vehicles.Add(Producer.ProduceVehicle(new JeepFactory()));
            vehicles.Add(Producer.ProduceVehicle(new ScooterFactory()));
            vehicles.Add(Producer.ProduceVehicle(new BikeFactory()));
            vehicles.Add(Producer.ProduceVehicle(new JeepFactory()));
            vehicles.Add(Producer.ProduceVehicle(new CarFactory()));
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Vehicle " + vehicle.VehecleName + " has " + vehicle.NumberOfWheels + " wheels.");
                Console.WriteLine(vehicle.GetType().FullName);
            }
            Console.ReadLine();
        }
    }
}
