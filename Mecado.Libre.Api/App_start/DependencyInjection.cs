using Mercado.Libre.Business;
using Mercado.Libre.Business.Common;
using Mercado.Libre.Business.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mecado.Libre.Api.App_start
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionConfig(this IServiceCollection services)
        {

            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("Mercado_Libre_Db"));
            services.AddScoped<ApiContext>();

            services.AddScoped(typeof(IloggerMl<>), typeof(loggerMl<>));
            services.AddScoped(typeof(ISatelliteBusiness), typeof(SatelliteBusiness));
            services.AddScoped(typeof(ISatelliteData), typeof(SatelliteData));

        }
    }
}
