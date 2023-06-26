namespace Aseguradora.Entidades;
public class Vehiculo {
    public int ID{get;set;}
    public int TitularID{get;set;}
    public string Dominio {get;set;}="";
    public string marca {get;set;}="";
    public int año {get;set;}

    public List<Poliza>? ListaPolizas {get;set;}
}