using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarTerceroUseCase{
    private readonly IRepositorioTercero _repo;
    public ListarTerceroUseCase (IRepositorioTercero repo){
        _repo=repo;
    }
    public List<Tercero> Ejecutar (){
       return _repo.listarTerceros();
    }
}