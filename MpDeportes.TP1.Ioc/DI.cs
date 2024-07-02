using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MpDeportes.TP1.Datos;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Datos.Repositorios;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Servicios.Servicios;

namespace MpDeportes.TP1.Ioc
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IRepositorioBrand,
                RepositorioBrand>();
            servicios.AddScoped<IRepositorioColor,
                RepositorioColor>();
            servicios.AddScoped<IRepositorioGenre,
                RepositorioGenre>();
            servicios.AddScoped<IRepositorioShoe,
                RepositorioShoe>();
            servicios.AddScoped<IRepositorioSport,
                RepositorioSport>();
            servicios.AddScoped<IRepositorioSize,
                RepositorioSize>();

            servicios.AddScoped<IServicioBrand,
                ServicioBrand>();
            servicios.AddScoped<IServicioColor,
                ServicioColor>();
            servicios.AddScoped<IServicioGenre,
                ServicioGenre>();
            servicios.AddScoped<IServicioShoe,
                ServicioShoe>();
            servicios.AddScoped<IServicioSport,
                ServicioSport>();
            servicios.AddScoped<IServicioSize,
                ServicioSize>();

            servicios.AddScoped<IUnitOfWork, UnitOfWork>();
            servicios.AddDbContext<MpDeportesDbContext>(optiones =>
            {
                optiones.UseSqlServer(@"Data Source=.; 
                        Initial Catalog=MpDeportes; 
                        Trusted_Connection=true; 
                        TrustServerCertificate=true;");
            });

            return servicios.BuildServiceProvider();
        }
    }
}
