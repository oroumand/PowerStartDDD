using DddZamin.Core.Contracts.Data.Commands;
using DddZamin.Core.Contracts.Data.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DddZamin.EndPoints.Web.Extentions.DependencyInjection;

public static class AddDataAccessExtentsions
{
    public static IServiceCollection AddZaminDataAccess(
        this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddRepositories(assembliesForSearch).AddUnitOfWorks(assembliesForSearch);

    public static IServiceCollection AddRepositories(this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddWithTransientLifetime(assembliesForSearch, typeof(ICommandRepository<,>), typeof(IQueryRepository));

    public static IServiceCollection AddUnitOfWorks(this IServiceCollection services,
        IEnumerable<Assembly> assembliesForSearch) =>
        services.AddWithTransientLifetime(assembliesForSearch, typeof(IUnitOfWork));
}
