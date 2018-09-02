using BLL.Services;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace API.ExtensionMethods
{
    public static class Injector
    {
        public static void Register(this IServiceCollection services)
        {
            //Register repositories
            services.AddScoped(typeof(IEthioRemitEntitiesRepository<>), typeof(EthioRemitEntitiesRepository<>));

            //Register services
            services.AddTransient<IClientTypeService, ClientTypeService>();
        }
    }
}
