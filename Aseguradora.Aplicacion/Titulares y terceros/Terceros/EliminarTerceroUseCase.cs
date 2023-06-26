using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class EliminarTerceroUseCase{
    private readonly IRepositorioTercero _repo;
    public EliminarTerceroUseCase (IRepositorioTercero repo){
        _repo=repo;
    }
    public void Ejecutar (int dni){
        _repo.eliminarTercero(dni);
    }
}