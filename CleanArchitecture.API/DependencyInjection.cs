﻿using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;

namespace CleanArchitecture.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI(configuration);
            return services;
        }
    }
}
