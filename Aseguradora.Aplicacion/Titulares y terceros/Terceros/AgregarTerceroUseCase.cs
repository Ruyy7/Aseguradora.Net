using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class AgregarTerceroUseCase{
    private readonly IRepositorioTercero _repo;
    public AgregarTerceroUseCase (IRepositorioTercero repo){
        _repo=repo;
    }
    public void Ejecutar (Tercero t){
        _repo.agregarTercero(t);
    }
}