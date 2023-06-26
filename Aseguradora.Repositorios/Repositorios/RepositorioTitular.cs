using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
using Aseguradora.Interfaces;
namespace Aseguradora.Repositorios;

public class RepositorioTitular : IRepositorioTitular{
    public void agregarTitular (Titular Titular){
        using (var context = new AseguradoraContext()){
            var TitularAgregar = context.Titular.Where (t => t.dni == Titular.dni).SingleOrDefault();
            if (TitularAgregar == null){
                context.Add(Titular);
                context.SaveChanges();
            }
            else{
                throw new Exception();
            }
        }
    }
    public List<Titular> listarTitulares(){
        using (var context = new AseguradoraContext()){
            List<Titular> ListaTitular = context.Titular.ToList();
            return ListaTitular;
        }
    }

    public void modificarTitular (Titular Titular){
        using (var context = new AseguradoraContext()){
            var TitularModificar = context.Titular.Where (t => t.dni == Titular.dni).SingleOrDefault();
            if (TitularModificar !=null){
                TitularModificar.nombre = Titular.nombre;
                TitularModificar.apellido = Titular.apellido;
                TitularModificar.telefono = Titular.telefono;
                TitularModificar.Correo = Titular.Correo;
                TitularModificar.Direccion = Titular.Direccion;
                context.SaveChanges();
            }
        }
    }

    public void eliminarTitular (int dni){
        using (var context = new AseguradoraContext()){
            var TitularEliminar = context.Titular.Where (t=> t.dni == dni).SingleOrDefault();
            if (TitularEliminar != null){
                context.Remove(TitularEliminar);
                context.SaveChanges();
            }
        }
    }

    public List<Titular> listarTitularesConVehiculos(){
        using (var context = new AseguradoraContext()){
            var listaTitulares = context.Titular.ToList();
            foreach (var titular in listaTitulares){
                var listaVehiculos = context.Vehiculo.Where(v => v.TitularID == titular.ID).ToList();
                titular.Vehiculos = listaVehiculos;
            }
        return listaTitulares;
        }
    }

    public Titular? ObtenerTitular(int dni){
        using (var context = new AseguradoraContext()){
            var Titular = context.Titular.Where (t => t.dni == dni).SingleOrDefault();
            if (Titular != null){
                return Titular;
            }
            else{
                return null;
            }
        }        
    }
}