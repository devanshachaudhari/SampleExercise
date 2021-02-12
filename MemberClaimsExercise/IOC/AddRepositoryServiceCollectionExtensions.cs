using BusinessModels.Csv;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public static class AddRepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Claim>, ClaimRepository>();
            services.AddScoped<IRepository<Member>, MemberRepository>();
            return services;
        }
    }

}
