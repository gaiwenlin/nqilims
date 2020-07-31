using NQI_LIMS.IServices;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using NQI_LIMS.SwaggerHelper;
using System.Linq;
using NQI_LIMS.Model;

namespace NQI_LIMS.Filter
{
    public class UseServiceDIAttribute : ActionFilterAttribute
    {

        protected readonly ILogger<UseServiceDIAttribute> _logger;
        private readonly IBlogArticleServices _blogArticleServices;
        private readonly string _name;

        public UseServiceDIAttribute(ILogger<UseServiceDIAttribute> logger, IBlogArticleServices blogArticleServices,string Name="")
        {
            _logger = logger;
            _blogArticleServices = blogArticleServices;
            _name = Name;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            //var dd =await _blogArticleServices.Query();
            if (!actionContext.HttpContext.User.Identity.IsAuthenticated &&
                actionContext.Filters.Any(item => item is MustLogin))
            {
                actionContext.Result= MyResponse.MustLogin<string>().GetResult();
                base.OnActionExecuting(actionContext);
                return;
            }
            base.OnActionExecuting(actionContext);
        }


        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //var dd =await _blogArticleServices.Query();
            base.OnActionExecuted(context);
            DeleteSubscriptionFiles();
        }

        private void DeleteSubscriptionFiles()
        {
            try
            {
                // ...
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error Delete Subscription Files");
            }
        }
    }
}
