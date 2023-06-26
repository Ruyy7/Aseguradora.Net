using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
using Aseguradora.Interfaces;
namespace Aseguradora.Repositorios;

public class RepositorioTercero : IRepositorioTercero{
    public void agregarTercero (Tercero tercero){
        using (var context = new AseguradoraContext()){
            var TerceroAgregar = context.Tercero.Where (t => t.dni == tercero.dni).SingleOrDefault();
            if (TerceroAgregar == null){
                context.Add(tercero);
                context.SaveChanges();
            }
        }
    }
    public List<Tercero> listarTerceros(){
        using (var context = new AseguradoraContext()){
            List<Tercero> ListaTercero = context.Tercero.ToList();
            return ListaTercero;
        }
    }

    public void modificarTercero (Tercero tercero){
        using (var context = new AseguradoraContext()){
            var TerceroModificar = context.Tercero.Where (t => t.dni == tercero.dni).SingleOrDefault();
            if (TerceroModificar !=null){
                TerceroModificar.nombre = tercero.nombre;
                TerceroModificar.apellido = tercero.apellido;
                TerceroModificar.telefono = tercero.telefono;
                TerceroModificar.nombreaseguradora = tercero.nombreaseguradora;
                context.SaveChanges();
            }
        }
    }

    public void eliminarTercero (int DNI){
        using (var context = new AseguradoraContext()){
            var TerceroEliminar = context.Tercero.Where (t => t.dni == DNI).SingleOrDefault();
            if (TerceroEliminar != null){
                context.Remove(TerceroEliminar);
                context.SaveChanges();
            }
        }
    }

    public Tercero? ObtenerTercero (int dni){
        using (var context = new AseguradoraContext()){
            var Tercero = context.Tercero.Where (t => t.dni == dni).SingleOrDefault();
            if (Tercero != null){
                return Tercero;
            }
            else{
                return null;
            }
        }        
    }
}