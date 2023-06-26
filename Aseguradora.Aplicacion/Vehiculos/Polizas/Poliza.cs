namespace Aseguradora.Entidades;
public class Poliza{
    public int ID {get;set;}
    public int VehiculoID {get;set;}
    public double valorasegurado {get;set;}
    public double franquicia {get;set;}
    public string? cobertura {get;set;}
    public DateTime fechainicio {get;set;} = new DateTime (2000,1,1);
    public DateTime fechafin {get;set;} = new DateTime (2000,1,1);

    public List<Siniestro>? ListaSiniestro {get;set;}
}