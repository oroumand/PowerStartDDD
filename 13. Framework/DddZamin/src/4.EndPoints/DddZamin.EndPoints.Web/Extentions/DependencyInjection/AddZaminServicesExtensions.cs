using Microsoft.Extensions.DependencyInjection;
using Zamin.Utilities;

namespace DddZamin.EndPoints.Web.Extentions.DependencyInjection;

public static class AddZaminServicesExtensions
{
    public static IServiceCollection AddZaminUntilityServices(
        this IServiceCollection services)
    {
        services.AddTransient<ZaminServices>();
        return services;
    }
}
