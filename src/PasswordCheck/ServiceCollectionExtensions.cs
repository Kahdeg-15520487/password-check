﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace PasswordCheck
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBreachedPasswordService(this IServiceCollection services)
        {
            services.AddScoped<IBreachedPasswordService, BreachedPasswordService>();
            services.AddHttpClient<IBreachedPasswordService, BreachedPasswordService>(client =>
            {
                client.BaseAddress = new Uri("https://api.pwnedpasswords.com");
            });
            return services;
        }
    }
}
