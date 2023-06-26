using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ObtenerSiniestroUseCase{
    private readonly IRepositorioSiniestro _repo;
    public ObtenerSiniestroUseCase (IRepositorioSiniestro repo){
        _repo=repo;
    }
    public Siniestro? Ejecutar (int ID){
        return _repo.ObtenerSiniestro (ID);
    }
}