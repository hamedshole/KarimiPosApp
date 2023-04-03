using Application.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationDependency
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork,UnitOfWork>();
            return services;
        }
    }
}
