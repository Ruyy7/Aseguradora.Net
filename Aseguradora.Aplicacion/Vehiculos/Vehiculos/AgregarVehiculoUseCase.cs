using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class AgregarVehiculoUseCase{
    private readonly IRepositorioVehiculo _repo;
    public AgregarVehiculoUseCase (IRepositorioVehiculo repo){
        _repo=repo;
    }
    public void Ejecutar (Vehiculo v){
        _repo.agregarVehiculo(v);
    }
}