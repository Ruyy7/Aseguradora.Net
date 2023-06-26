using Aseguradora.Interfaces;
using Aseguradora.Entidades;
namespace Aseguradora.UseCases;
public class EliminarPolizaUseCase{
    private readonly IRepositorioPoliza _repo;
    public EliminarPolizaUseCase (IRepositorioPoliza repo){
        _repo=repo;
    }
    public void Ejecutar (int ID){
        _repo.EliminarPoliza (ID);
    }
}