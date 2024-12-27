using Microsoft.AspNetCore.Mvc.Filters;

namespace SEA_ApiTest.Models.Attribute
{
    public interface IFilterStartWithContext
    {
        void OnActionStart(ActionExecutingContext context);
    }
}
