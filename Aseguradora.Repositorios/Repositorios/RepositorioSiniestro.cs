using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
using Aseguradora.Interfaces;
namespace Aseguradora.Repositorios;

public class RepositorioSiniestro : IRepositorioSiniestro{
    public void AgregarSiniestro (Siniestro Siniestro){
        using (var context = new AseguradoraContext()){
            var SiniestroAgregar = context.Siniestro.Where (s => s.ID == Siniestro.ID).SingleOrDefault();
            if (SiniestroAgregar == null){
                var PolizaChequeo = context.Poliza.Where (p => p.ID == Siniestro.PolizaID).SingleOrDefault();
                if ((PolizaChequeo != null) && (Siniestro.fechaocurrencia <= PolizaChequeo.fechafin) && (Siniestro.fechaocurrencia >= PolizaChequeo.fechainicio)){
                    context.Add(Siniestro);
                    context.SaveChanges();
                }
                else{
                    throw new Exception();
                }
            }
        }
    }
    public List<Siniestro> listarSiniestros(){
        using (var context = new AseguradoraContext()){
            List<Siniestro> ListaSiniestro = context.Siniestro.ToList();
            return ListaSiniestro;
        }
    }

    public void ModificarSiniestro (Siniestro Siniestro){
        using (var context = new AseguradoraContext()){
            var SiniestroModificar = context.Siniestro.Where (s => s.ID == Siniestro.ID).SingleOrDefault();
            if (SiniestroModificar !=null){
                SiniestroModificar.descripcion = Siniestro.descripcion;
                SiniestroModificar.direccion = Siniestro.direccion;
                SiniestroModificar.fechaingreso = Siniestro.fechaingreso;
                SiniestroModificar.fechaocurrencia = Siniestro.fechaocurrencia;
                context.SaveChanges();
            }
        }
    }

    public void EliminarSiniestro (int id){
        using (var context = new AseguradoraContext()){
            var SiniestroEliminar = context.Siniestro.Where (s => s.ID == id).SingleOrDefault();
            if (SiniestroEliminar != null){
                context.Remove(SiniestroEliminar);
                context.SaveChanges();
            }
        }
    }

    public Siniestro? ObtenerSiniestro (int id){
        using (var context = new AseguradoraContext()){
            var Siniestro = context.Siniestro.Where (s => s.ID == id).SingleOrDefault();
            if (Siniestro != null){
                return Siniestro;
            }
            else{
                return null;
            }
        }        
    }
}