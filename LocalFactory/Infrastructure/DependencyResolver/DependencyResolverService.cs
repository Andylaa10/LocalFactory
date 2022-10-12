using Application;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyResolver;

public class DependencyResolverService
{
    public static void RegisterInfrastructureLayer(IServiceCollection services)
    {
        services.AddScoped<IBoxRepository, BoxRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
    }
}