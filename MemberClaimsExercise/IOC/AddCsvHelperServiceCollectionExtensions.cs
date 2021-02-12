using CsvHelperLib;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public static class AddCsvHelperServiceCollectionExtensions
    {
        public static IServiceCollection AddCsvHelperService(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICsvParserService<>), typeof(CsvParserService<>));
            return services;
        }
    }
}
