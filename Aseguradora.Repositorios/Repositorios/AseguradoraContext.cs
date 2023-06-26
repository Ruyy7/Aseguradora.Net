using Microsoft.EntityFrameworkCore;
using Aseguradora.Entidades;
namespace Aseguradora.Repositorios;

public class AseguradoraContext : DbContext{
    #nullable disable
    public DbSet<Titular> Titular {get;set;}
    public DbSet<Tercero> Tercero {get;set;}
    public DbSet<Vehiculo> Vehiculo {get;set;}
    public DbSet<Poliza> Poliza {get;set;}
    public DbSet<Siniestro> Siniestro {get;set;}
    #nullable restore

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}