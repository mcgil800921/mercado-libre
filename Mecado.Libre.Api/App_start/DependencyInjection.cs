using Mercado.Libre.Business;
using Mercado.Libre.Business.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Mecado.Libre.Api.App_start
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped(typeof(IloggerMl<>), typeof(loggerMl<>));
            services.AddScoped(typeof(ISatelliteBusiness), typeof(SatelliteBusiness));

        }
    }
}
