using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NQI_LIMS.Api.Controllers.CJORACLE
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PM_INSPECTController : ControllerBase
    {
        private readonly IPM_INSPECTServices _PM_INSPECTServices;

        public PM_INSPECTController(IPM_INSPECTServices PM_INSPECTServices)
        {
            _PM_INSPECTServices = PM_INSPECTServices;
        }
        #region 根据抽查批次号获取抽查信息
        [HttpPost]
        public ActionResult GetPmInsPectByCode(string iCodeNum)
        {
            JObject jo = _PM_INSPECTServices.GetPmInsPectByCode(iCodeNum);
            return MyResponse.Return<JObject>(jo).GetResult();
        }
        #endregion
    }
}