using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAppMVC2Tier.Models
{
    public class SetSession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context) // filter
        {
            var res = context.HttpContext.Session.GetString("mykey");
            if (res == null)
            {
                context.Result =
                  new RedirectToRouteResult(
                      new RouteValueDictionary {
                            {
                           "controller", "Usersops" },
                            { "action","Authenticate" }
                      });
            }
        }

    }
}
