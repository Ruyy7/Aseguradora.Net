using Aseguradora.Entidades;
namespace Aseguradora.Interfaces;
public interface IRepositorioPoliza{
    void AgregarPoliza(Poliza poliza);
    void ModificarPoliza (Poliza poliza);
    void EliminarPoliza (int ID);
    Poliza? ObtenerPoliza (int ID);
    List<Poliza> listarPolizas();
}