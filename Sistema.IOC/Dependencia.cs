using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IngresoDeposito.DAL.Repositories;
using IngresoDeposito.DAL.Repositories.Contract;

namespace IngresoDeposito.IOC
{
    public static class Dependencia
    {
        /* Reemplazar "DBContext" por el contexto generado desde EntityFramework, descomentar el bloque para activar el contexto. */

        public static void InyectarDependencias(this IServiceCollection services, IConfiguration config)
        {
            //services.AddDbContext<DBContext>(options =>
            //{
            //    options.UseSqlServer(config.GetConnectionString("conexionSQL"));
            //});

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
