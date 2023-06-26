using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class EliminarTitularUseCase{
    private readonly IRepositorioTitular _repo;
    public EliminarTitularUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public void Ejecutar (int dni){
        _repo.eliminarTitular(dni);
    }
}