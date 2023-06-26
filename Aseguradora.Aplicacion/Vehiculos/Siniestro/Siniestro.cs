namespace Aseguradora.Entidades;
public class Siniestro {
    public int ID {get;set;}
    public int PolizaID {get;set;}
    public DateTime fechaingreso {get;set;} = new DateTime (2000,1,1);
    public DateTime fechaocurrencia {get;set;} = new DateTime (2000,1,1);
    public string? direccion {get;set;}
    public string? descripcion {get;set;}

    public List<Tercero>? ListaTercero {get;set;}
}