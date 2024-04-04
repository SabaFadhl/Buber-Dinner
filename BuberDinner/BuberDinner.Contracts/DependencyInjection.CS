using BuberDinner.Application.Services.Authentcation;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service){
        service.AddScoped<IAuthentcationService, AuthentcationService>();
        return service;
    }
}