using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ObtenerVehiculoUseCase{
    private readonly IRepositorioVehiculo _repo;
    public ObtenerVehiculoUseCase (IRepositorioVehiculo repo){
        _repo=repo;
    }
    public Vehiculo? Ejecutar (int ID){
        return _repo.ObtenerVehiculo(ID);
    }
}