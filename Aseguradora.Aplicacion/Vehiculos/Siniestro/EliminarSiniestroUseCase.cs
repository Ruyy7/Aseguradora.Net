using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class EliminarSiniestroUseCase{
    private readonly IRepositorioSiniestro _repo;
    public EliminarSiniestroUseCase (IRepositorioSiniestro repo){
        _repo=repo;
    }
    public void Ejecutar (int ID){
        _repo.EliminarSiniestro (ID);
    }
}