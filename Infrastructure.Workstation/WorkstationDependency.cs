using Domain.Interfaces;
using Infrastructure.Workstation.ModelFactory;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure.Workstation
{
    public static class WorkstationDependency
    {
        public static IServiceCollection RegisterWorkstation(this IServiceCollection services)
        {
            services.AddSingleton<IModelFactory>(new ModelUnit());
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            WorkstationAccess workstationAccess = new WorkstationAccess(serviceProvider.GetRequiredService<IModelFactory>(), serviceProvider.GetRequiredService<IUnitOfWork>());
            services.AddSingleton<IWorkstationAccess>(workstationAccess);
            return services;
        }
    }
}
