using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern.Base
{
    public abstract class FourWheelerFactory : IFourWheelerFactory
    {
        public abstract IFourWheeler CreateVehicle();
    }
}
