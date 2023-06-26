using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ListarSiniestroUseCase {
    private readonly IRepositorioSiniestro _repo;
    public ListarSiniestroUseCase (IRepositorioSiniestro repo){
        _repo=repo;
    }
    public List<Siniestro> Ejecutar(){
        return _repo.listarSiniestros();
    }
}