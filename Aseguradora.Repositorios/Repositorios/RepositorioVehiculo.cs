using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
using Aseguradora.Interfaces;
namespace Aseguradora.Repositorios;

public class RepositorioVehiculo : IRepositorioVehiculo{
    public void agregarVehiculo (Vehiculo Vehiculo){
        using (var context = new AseguradoraContext()){
            var VehiculoAgregar = context.Vehiculo.Where (v => v.ID == Vehiculo.ID).SingleOrDefault();
            var ChequeoDominio = context.Vehiculo.Where (v => v.Dominio == Vehiculo.Dominio).SingleOrDefault();
            if ((VehiculoAgregar == null) && (ChequeoDominio == null)){
                context.Add(Vehiculo);
                context.SaveChanges();
            }
            else{
                throw new Exception();
            }
        }
    }
    public List<Vehiculo> listarVehiculos(){
        using (var context = new AseguradoraContext()){
            List<Vehiculo> ListaVehiculo = context.Vehiculo.ToList();
            return ListaVehiculo;
        }
    }

    public void modificarVehiculo (Vehiculo Vehiculo){
        using (var context = new AseguradoraContext()){
            var VehiculoModificar = context.Vehiculo.Where (v => v.ID == Vehiculo.ID).SingleOrDefault();
            if ((VehiculoModificar !=null)){
                VehiculoModificar.Dominio = Vehiculo.Dominio;
                VehiculoModificar.marca = Vehiculo.marca;
                VehiculoModificar.año = Vehiculo.año;
                context.SaveChanges();
            }
        }
    }

    public void eliminarVehiculo (int id){
        using (var context = new AseguradoraContext()){
            var VehiculoEliminar = context.Vehiculo.Where (v => v.ID == id).SingleOrDefault();
            if (VehiculoEliminar!=null){
                context.Remove(VehiculoEliminar);
                context.SaveChanges();
                }
            }
        }

    public Vehiculo? ObtenerVehiculo (int id){
        using (var context = new AseguradoraContext()){
            var Vehiculo = context.Vehiculo.Where (v => v.ID == id).SingleOrDefault();
            if (Vehiculo != null){
                return Vehiculo;
            }
            else{
                return null;
            }
        }        
    }
}