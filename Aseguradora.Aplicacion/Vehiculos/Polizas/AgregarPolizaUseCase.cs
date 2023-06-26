using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class AgregarPolizaUseCase{
    private readonly IRepositorioPoliza _repo;
    public AgregarPolizaUseCase (IRepositorioPoliza repo){
        _repo=repo;
    }
    public void Ejecutar (Poliza poliza){
        _repo.AgregarPoliza(poliza);
    }
}
