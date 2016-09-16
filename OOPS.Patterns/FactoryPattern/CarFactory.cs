using OOPS.Patterns.FactoryPattern.Base;
using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern
{
    public class CarFactory : FourWheelerFactory
    {
        public override IFourWheeler CreateVehicle()
        {
            return new Car();
        }
    }
}