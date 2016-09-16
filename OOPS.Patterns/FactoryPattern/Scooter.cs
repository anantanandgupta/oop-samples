using OOPS.Patterns.FactoryPattern.Base;

namespace OOPS.Patterns.FactoryPattern
{
    public class Scooter : TwoWheeler
    {
        public sealed override string VehecleName { get; set; }
        
        public Scooter()
        {
            VehecleName = "Scooter";
        }
    }
}
