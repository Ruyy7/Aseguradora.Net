namespace Aseguradora.Entidades;
public class Titular:Persona{
    // public Titular(int DNI, string apellido, string nombre):base(DNI,apellido,nombre){}
    public string? Direccion {get;set;}="";
    
    public string? Correo {get;set;}="";

    public override string ToString(){
        return ($"{ID}: {dni} {apellido}, {nombre} {Direccion} {telefono} {Correo}");
    }
    public List<Vehiculo>? Vehiculos {get;set;}
}