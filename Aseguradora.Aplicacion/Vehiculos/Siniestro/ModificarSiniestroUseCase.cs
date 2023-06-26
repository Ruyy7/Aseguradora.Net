using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ModificarSiniestroUseCase{
    private readonly IRepositorioSiniestro _repo;
    public ModificarSiniestroUseCase (IRepositorioSiniestro repo){
        _repo=repo;
    }
    public void Ejecutar (Siniestro s){
        _repo.ModificarSiniestro(s);
    }
}