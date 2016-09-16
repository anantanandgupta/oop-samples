using OOPS.Patterns.FactoryPattern.Base;

namespace OOPS.Patterns.FactoryPattern
{
    public class Bike : TwoWheeler
    {
        public sealed override string VehecleName { get; set; }

        public Bike()
        {
            VehecleName = "Bike";
        }
    }
}
