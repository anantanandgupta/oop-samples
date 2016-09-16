using OOPS.Patterns.FactoryPattern.Base;

namespace OOPS.Patterns.FactoryPattern
{
    public class Jeep : FourWheeler
    {
        public sealed override string VehecleName { get; set; }
        public Jeep()
        {
            VehecleName = "Jeep";
        }
    }
}
