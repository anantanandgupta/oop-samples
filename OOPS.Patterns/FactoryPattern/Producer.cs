using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern
{
    public class Producer
    {
        public static IVehicle ProduceVehicle(IVehicleFactory<IVehicle> factory)
        {
            return factory.CreateVehicle();
        }
    }
}
