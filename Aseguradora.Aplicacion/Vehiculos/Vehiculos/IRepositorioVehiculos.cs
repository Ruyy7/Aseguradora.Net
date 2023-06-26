using Aseguradora.Entidades;
namespace Aseguradora.Interfaces;
public interface IRepositorioVehiculo{
    void agregarVehiculo (Vehiculo vehiculo);
    void modificarVehiculo (Vehiculo vehiculo);
    void eliminarVehiculo (int ID);
    Vehiculo? ObtenerVehiculo (int ID);
    List<Vehiculo> listarVehiculos();
}