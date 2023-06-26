using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarPolizasUseCase {
    private readonly IRepositorioPoliza _repo;
    public ListarPolizasUseCase (IRepositorioPoliza repo){
        _repo=repo;
    }
    public List<Poliza> Ejecutar(){
        return _repo.listarPolizas();
    }
}