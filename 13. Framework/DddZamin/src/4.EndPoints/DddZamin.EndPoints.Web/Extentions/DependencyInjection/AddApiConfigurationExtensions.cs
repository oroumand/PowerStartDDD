using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddZamin.EndPoints.Web.Extentions.DependencyInjection;
public static class AddApiConfigurationExtensions
    {
        public static IServiceCollection AddZaminApiCore(this IServiceCollection services, params string[] assemblyNamesForLoad)
        {
            services.AddControllers().AddFluentValidation();
            services.AddZaminDependencies(assemblyNamesForLoad);

            return services;
        }

        //public static void UseZaminApiExceptionHandler(this IApplicationBuilder app)
        //{

        //    app.UseApiExceptionHandler(options =>
        //    {
        //        options.AddResponseDetails = (context, ex, error) =>
        //        {
        //            if (ex.GetType().Name == typeof(Microsoft.Data.SqlClient.SqlException).Name)
        //            {
        //                error.Detail = "Exception was a database exception!";
        //            }
        //        };
        //        options.DetermineLogLevel = ex =>
        //        {
        //            if (ex.Message.StartsWith("cannot open database", StringComparison.InvariantCultureIgnoreCase) ||
        //                ex.Message.StartsWith("a network-related", StringComparison.InvariantCultureIgnoreCase))
        //            {
        //                return LogLevel.Critical;
        //            }
        //            return LogLevel.Error;
        //        };
        //    });

        //}
    }
