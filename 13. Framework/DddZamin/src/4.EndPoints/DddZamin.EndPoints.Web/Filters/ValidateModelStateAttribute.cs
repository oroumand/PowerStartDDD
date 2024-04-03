using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace DddZamin.EndPoints.Web.Filters;
public class ValidateModelStateAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = context.ModelState.Where(x => x.Value.Errors.Any()).Select(kvp => string.Join(", ", kvp.Value.Errors.Select(p => p.ErrorMessage))).ToList();
            context.Result = new BadRequestObjectResult(errors);
        }
    }
}