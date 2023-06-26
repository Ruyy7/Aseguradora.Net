using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ObtenerPolizaUseCase{
    private readonly IRepositorioPoliza _repo;
    public ObtenerPolizaUseCase (IRepositorioPoliza repo){
        _repo=repo;
    }
    public Poliza? Ejecutar (int ID){
        return _repo.ObtenerPoliza (ID);
    }
}