﻿using System;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NQI_LIMS.Model.ViewModels;
using NQI_LIMS.Common.HttpContextUser;
using NQI_LIMS.SwaggerHelper;

namespace NQI_LIMS.Api.Controllers.LIMSORACLE
{
    /// <summary>
    /// 监督抽查数据同步
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(Permissions.Name)]
    public class InspectAcceptanceController : ControllerBase
    {
        private readonly IInspectAcceptanceServices _InspectAcceptanceServices;
        private readonly IUser _user;

        public InspectAcceptanceController(IInspectAcceptanceServices InspectAcceptanceServices, IUser user)
        {
            _InspectAcceptanceServices = InspectAcceptanceServices;
            _user = user;
        }

        #region 保存抽查业务信息
        /// <summary>
        /// 保存抽查业务信息
        /// </summary>
        /// <param name="iModel"></param>
        /// <returns></returns>
        [HttpPost]  
        [MustLogin]
        public ActionResult SaveInspectAcceptance([FromBody] InputInsepectAcceptanceModel iModel)
        {
            bool jo = _InspectAcceptanceServices.SaveInspectAcceptance(12,iModel);
            return MyResponse.Return<int>(jo?1:0).GetResult();
        }
        #endregion

    }
}