using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ObtenerTitularUseCase{
    private readonly IRepositorioTitular _repo;
    public ObtenerTitularUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public Titular? Ejecutar (int dni){
        return _repo.ObtenerTitular(dni);
    }
}