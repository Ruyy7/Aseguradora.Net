using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
using Aseguradora.Interfaces;
namespace Aseguradora.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza{
    public void AgregarPoliza (Poliza Poliza){
        using (var context = new AseguradoraContext()){
            var PolizaAgregar = context.Poliza.Where (p => p.ID == Poliza.ID).SingleOrDefault();
            if (PolizaAgregar == null){
                context.Add(Poliza);
                context.SaveChanges();
            }
        }
    }
    public List<Poliza> listarPolizas(){
        using (var context = new AseguradoraContext()){
            List<Poliza> ListaPoliza = context.Poliza.ToList();
            return ListaPoliza;
        }
    }

    public void ModificarPoliza (Poliza Poliza){
        using (var context = new AseguradoraContext()){
            var PolizaModificar = context.Poliza.Where (p => p.ID == Poliza.ID).SingleOrDefault();
            if (PolizaModificar !=null){
                PolizaModificar.valorasegurado = Poliza.valorasegurado;
                PolizaModificar.franquicia = Poliza.franquicia;
                PolizaModificar.cobertura = Poliza.cobertura;
                PolizaModificar.fechainicio = Poliza.fechainicio;
                PolizaModificar.fechafin = Poliza.fechafin;
                context.SaveChanges();
            }
        }
    }

    public void EliminarPoliza (int id){
        using (var context = new AseguradoraContext()){
            var PolizaEliminar = context.Poliza.Where (p => p.ID == id).SingleOrDefault();
            if (PolizaEliminar != null){
                context.Remove(PolizaEliminar);
                context.SaveChanges();
            }
        }
    }

    public Poliza? ObtenerPoliza (int id){
        using (var context = new AseguradoraContext()){
            var Poliza = context.Poliza.Where (p => p.ID == id).SingleOrDefault();
            if (Poliza != null){
                return Poliza;
            }
            else{
                return null;
            }
        }
    }
}