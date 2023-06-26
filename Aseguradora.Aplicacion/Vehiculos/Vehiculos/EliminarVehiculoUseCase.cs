using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class EliminarVehiculoUseCase{
    private readonly IRepositorioVehiculo _repo;
    public EliminarVehiculoUseCase (IRepositorioVehiculo repo){
        _repo=repo;
    }
    public void Ejecutar (int ID){
        _repo.eliminarVehiculo(ID);
    }
}