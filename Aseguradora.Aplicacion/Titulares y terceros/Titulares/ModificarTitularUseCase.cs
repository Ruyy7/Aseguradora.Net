using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class ModificarTitularUseCase{
    private readonly IRepositorioTitular _repo;
    public ModificarTitularUseCase (IRepositorioTitular repo){
        _repo=repo;
    }
    public void Ejecutar (Titular t){
        _repo.modificarTitular(t);
    }
}