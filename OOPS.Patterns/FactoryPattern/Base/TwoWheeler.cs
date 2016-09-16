using OOPS.Patterns.FactoryPattern.Interfaces;

namespace OOPS.Patterns.FactoryPattern.Base
{
    public abstract class TwoWheeler : ITwoWheeler
    {
        public abstract string VehecleName { get; set; }
        public int NumberOfWheels { get; set; }

        protected TwoWheeler()
        {
            NumberOfWheels = 2;
        }
    }
}
