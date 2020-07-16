using System;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NQI_LIMS.Model.ViewModels;

namespace NQI_LIMS.Api.Controllers.LIMSORACLE
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectAcceptanceController : ControllerBase
    {
        private readonly IInspectAcceptanceServices _InspectAcceptanceServices;

        public InspectAcceptanceController(IInspectAcceptanceServices InspectAcceptanceServices)
        {
            _InspectAcceptanceServices = InspectAcceptanceServices;
        }

        #region 保存抽查业务信息
        [HttpPost]
        public ActionResult SaveInspectAcceptance([FromBody] InputInsepectAcceptanceModel iModel)
        {
            bool jo = _InspectAcceptanceServices.SaveInspectAcceptance(iModel);
            return MyResponse.Return<int>(jo?1:0).GetResult();
        }
        #endregion

    }
}