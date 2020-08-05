using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common.HttpContextUser;
using NQI_LIMS.SwaggerHelper;

namespace NQI_LIMS.Api.Controllers.CJORACLE
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   // [Authorize(Permissions.Name)]
    public class PM_INSPECTController : ControllerBase
    {
        private readonly IPM_INSPECTServices _PM_INSPECTServices;
        private readonly IUser _user;
        public PM_INSPECTController(IPM_INSPECTServices PM_INSPECTServices,IUser user)
        {
            _PM_INSPECTServices = PM_INSPECTServices;
            _user = user;
        }

        #region 根据抽查批次号获取抽查信息
        [HttpPost]
        [MustLogin]
        public ActionResult GetPmInsPectByCode(string iCodeNum)
        {
            JObject jo = _PM_INSPECTServices.GetPmInsPectByCode(_user.ID, iCodeNum);
            return MyResponse.Return<JObject>(jo).GetResult();
        }
        #endregion
    }
}