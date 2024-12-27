using SEA_ApiTest.Extension;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.Models.Attribute
{

    public abstract class BaseActionFilter : ActionFilterAttribute
    { 
        protected HttpContext httpContext;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            httpContext = context.HttpContext;
            if (this.hasInterface<IFilterStart>())
                ((IFilterStart)this).OnActionStart();
            else if (this.hasInterface<IFilterStartWithContext>())
                ((IFilterStartWithContext)this).OnActionStart(context);
        }


    }
}
