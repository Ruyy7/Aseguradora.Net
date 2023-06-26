using Aseguradora.Entidades;
namespace Aseguradora.Interfaces;
public interface IRepositorioTitular{
    void agregarTitular (Titular titular);
    void modificarTitular (Titular titular);
    void eliminarTitular (int dni);
    Titular? ObtenerTitular (int dni);
    List<Titular> listarTitulares();
    List<Titular> listarTitularesConVehiculos();
}