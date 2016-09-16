namespace OOPS.Patterns.FactoryPattern.Interfaces
{
    public interface IVehicleFactory<out T> where T : IVehicle
    {
        T CreateVehicle();
    }
}
