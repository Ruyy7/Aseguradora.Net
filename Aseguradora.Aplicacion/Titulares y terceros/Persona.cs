namespace Aseguradora.Entidades;
public abstract class Persona
{
    public int dni {get;set;}
    public string? apellido {get;set;}
    public string? nombre {get;set;}
    public Persona (int DNI,string apellido, string nombre){
        this.dni=DNI;
        this.apellido=apellido;
        this.nombre=nombre;
    }
    public Persona (){

    }
    public int ID {get;set;}
    public string? telefono {get;set;}="";
}
