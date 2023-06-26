using Aseguradora.Entidades;
namespace Aseguradora.Interfaces;
public interface IRepositorioTercero{
    void agregarTercero (Tercero tercero);
    void modificarTercero (Tercero tercero);
    void eliminarTercero (int dni);
    Tercero? ObtenerTercero (int dni);
    List<Tercero> listarTerceros();
}