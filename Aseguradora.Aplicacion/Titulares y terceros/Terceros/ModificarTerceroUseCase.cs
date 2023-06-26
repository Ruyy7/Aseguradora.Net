using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ModificarTerceroUseCase{
    private readonly IRepositorioTercero _repo;
    public ModificarTerceroUseCase (IRepositorioTercero repo){
        _repo=repo;
    }
    public void Ejecutar (Tercero t){
        _repo.modificarTercero(t);
    }
}