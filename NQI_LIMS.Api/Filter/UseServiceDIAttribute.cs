using NQI_LIMS.IServices;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using NQI_LIMS.SwaggerHelper;
using System.Linq;
using NQI_LIMS.Model;
using NQI_LIMS.Common.HttpContextUser;

namespace NQI_LIMS.Filter
{
    public class UseServiceDIAttribute : ActionFilterAttribute
    {

        protected readonly ILogger<UseServiceDIAttribute> _logger;
        private readonly IBlogArticleServices _blogArticleServices;
        private readonly string _name;
        private readonly IUser _user;

        public UseServiceDIAttribute(ILogger<UseServiceDIAttribute> logger, IBlogArticleServices blogArticleServices, IUser user,string Name="")
        {
            _logger = logger;
            _blogArticleServices = blogArticleServices;
            _name = Name;
            _user = user;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            //var dd =await _blogArticleServices.Query();
            if (actionContext.Filters.Any(item => item is MustLogin))
            {
                string ClaimType = "jti";
                var getUserInfoByToken = _user.GetUserInfoFromToken(ClaimType);
                if (!_user.IsAuthenticated())
                {
                    actionContext.Result = MyResponse.MustLogin<string>().GetResult();
                    base.OnActionExecuting(actionContext);
                    return;
                }
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
