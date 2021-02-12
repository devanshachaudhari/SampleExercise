using BusinessServices;
using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public static class AddBusinessServicesCollectionExtensions
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.AddScoped<IClaimService, ClaimService>();
            return services;
        }
    }
}
