using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ModificarPolizaUseCase{
    private readonly IRepositorioPoliza _repo;
    public ModificarPolizaUseCase (IRepositorioPoliza repo){
        _repo=repo;
    }
    public void Ejecutar (Poliza p){
        _repo.ModificarPoliza(p);
    }
}