using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection BootstrapDependency(this IServiceCollection services)
        {
            services.AddCsvHelperService();
            services.AddRepositoryService();
            services.AddBusinessService();

            return services;
        }

    }
}
