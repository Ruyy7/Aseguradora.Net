using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarTitularesConSusVehiculosUseCase{
    private readonly IRepositorioTitular _repo;
    public ListarTitularesConSusVehiculosUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public List<Titular> Ejecutar (){
        return _repo.listarTitularesConVehiculos();
    }
}