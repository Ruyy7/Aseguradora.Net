using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarTitularUseCase{
    private readonly IRepositorioTitular _repo;
    public ListarTitularUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public List<Titular> Ejecutar (){
       return _repo.listarTitulares();
    }
}