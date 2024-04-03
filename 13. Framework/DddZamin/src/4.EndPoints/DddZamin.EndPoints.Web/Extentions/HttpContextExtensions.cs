using DddZamin.Core.Contracts.ApplicationServices.Commands;
using DddZamin.Core.Contracts.ApplicationServices.Events;
using DddZamin.Core.Contracts.ApplicationServices.Queries;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Utilities;

namespace DddZamin.EndPoints.Web.Extentions
{
    public static class HttpContextExtensions
    {
        public static ICommandDispatcher CommandDispatcher(this HttpContext httpContext) =>
            (ICommandDispatcher)httpContext.RequestServices.GetService(typeof(ICommandDispatcher));

        public static IQueryDispatcher QueryDispatcher(this HttpContext httpContext) =>
            (IQueryDispatcher)httpContext.RequestServices.GetService(typeof(IQueryDispatcher));
        public static IEventDispatcher EventDispatcher(this HttpContext httpContext) =>
            (IEventDispatcher)httpContext.RequestServices.GetService(typeof(IEventDispatcher));
        public static ZaminServices ZaminApplicationContext(this HttpContext httpContext) =>
            (ZaminServices)httpContext.RequestServices.GetService(typeof(ZaminServices));
    }
}
