using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Aseguradora.Repositorios;
using Aseguradora.UseCases;
using Aseguradora.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

AseguradoraInizializar a = new AseguradoraInizializar();
a.InizializarBaseDeDatos();

builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<AgregarTerceroUseCase>();

builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();

builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();

builder.Services.AddTransient<ListarTitularUseCase>();
builder.Services.AddTransient<ListarTitularesConSusVehiculosUseCase>();
builder.Services.AddTransient<ListarVehiculoUseCase>();
builder.Services.AddTransient<ListarPolizasUseCase>();
builder.Services.AddTransient<ListarSiniestroUseCase>();
builder.Services.AddTransient<ListarTerceroUseCase>();

builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();

builder.Services.AddSingleton<IRepositorioTitular,RepositorioTitular>();
builder.Services.AddSingleton<IRepositorioVehiculo,RepositorioVehiculo>();
builder.Services.AddSingleton<IRepositorioPoliza,RepositorioPoliza>();
builder.Services.AddSingleton<IRepositorioSiniestro,RepositorioSiniestro>();
builder.Services.AddSingleton<IRepositorioTercero,RepositorioTercero>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();