using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern.Base
{
    public abstract class TwoWheelerFactory: ITwoWheelerFactory
    {
        public abstract ITwoWheeler CreateVehicle();
    }
}
