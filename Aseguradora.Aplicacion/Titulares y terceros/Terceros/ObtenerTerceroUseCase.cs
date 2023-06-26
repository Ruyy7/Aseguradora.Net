using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ObtenerTerceroUseCase{
    private readonly IRepositorioTercero _repo;
    public ObtenerTerceroUseCase (IRepositorioTercero repo){
        _repo=repo;
    }
    public Tercero? Ejecutar (int dni){
        return _repo.ObtenerTercero(dni);
    }
}