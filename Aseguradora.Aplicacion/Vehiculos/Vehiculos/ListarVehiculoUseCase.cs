using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarVehiculoUseCase{
    private readonly IRepositorioVehiculo _repo;
    public ListarVehiculoUseCase (IRepositorioVehiculo repo){
        _repo=repo;
    }
    public List<Vehiculo> Ejecutar (){
        return _repo.listarVehiculos();
    }
}