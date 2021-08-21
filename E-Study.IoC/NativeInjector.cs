using E_Study.Application.Interfaces;
using E_Study.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace E_Study.IoC
{
    public static class NativeInjector
    {

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
