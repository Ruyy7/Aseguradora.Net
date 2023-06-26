using Aseguradora.Entidades;
namespace Aseguradora.Interfaces;
public interface IRepositorioSiniestro{
    void AgregarSiniestro(Siniestro Siniestro);
    void ModificarSiniestro (Siniestro Siniestro);
    void EliminarSiniestro (int ID);
    Siniestro? ObtenerSiniestro (int ID);
    List<Siniestro> listarSiniestros();
}