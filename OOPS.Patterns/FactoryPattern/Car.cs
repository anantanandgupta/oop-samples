using OOPS.Patterns.FactoryPattern.Base;

namespace OOPS.Patterns.FactoryPattern
{
    public class Car : FourWheeler
    {
        public sealed override string VehecleName { get; set; }
        public Car()
        {
            VehecleName = "Car";
        }
    }
}
