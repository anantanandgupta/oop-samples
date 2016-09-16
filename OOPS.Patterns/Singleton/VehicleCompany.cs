using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.Singleton
{
    public class VehicleCompany
    {
        private static readonly VehicleCompany ProducerInstance = new VehicleCompany();
        public static VehicleCompany Instance {
            get
            {
                return ProducerInstance;
            }
        }

        public IVehicle ProduceVehicle(IVehicleFactory<IVehicle> factory)
        {
            return factory.CreateVehicle();
        }
    }
}
