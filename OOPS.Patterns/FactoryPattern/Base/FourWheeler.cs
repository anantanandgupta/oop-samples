using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern.Base
{
    public abstract class FourWheeler : IFourWheeler
    {
        public abstract string VehecleName { get; set; }
        public int NumberOfWheels { get; set; }

        protected FourWheeler()
        {
            NumberOfWheels = 4;
        }
    }
}
