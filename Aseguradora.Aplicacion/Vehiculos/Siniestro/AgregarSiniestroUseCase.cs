using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class AgregarSiniestroUseCase{
    private readonly IRepositorioSiniestro _repo;
    public AgregarSiniestroUseCase (IRepositorioSiniestro repo){
        _repo=repo;
    }
    public void Ejecutar (Siniestro Siniestro){
        _repo.AgregarSiniestro(Siniestro);
    }
}
