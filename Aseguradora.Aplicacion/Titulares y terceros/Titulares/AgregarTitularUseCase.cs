using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class AgregarTitularUseCase{
    private readonly IRepositorioTitular _repo;
    public AgregarTitularUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public void Ejecutar (Titular t){
        _repo.agregarTitular(t);
    }
}