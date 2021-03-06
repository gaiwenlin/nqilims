using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NQI_LIMS.Api.Controllers
{
    /// <summary>
    /// 抽查批次表
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Permissions.Name)]
    public class PM_PLAN_SUBController : ControllerBase
    {
        /// <summary>
        /// 服务器接口，因为是模板生成，所以首字母是大写的，自己可以重构下
        /// </summary>
        private readonly IPM_PLAN_SUBServices _PM_PLAN_SUBServices;

        #region  自动生成代码

        public PM_PLAN_SUBController(IPM_PLAN_SUBServices PM_PLAN_SUBServices)
        {
            _PM_PLAN_SUBServices = PM_PLAN_SUBServices;
        }

        [HttpGet]
        public async Task<MessageModel<PageModel<PM_PLAN_SUB>>> Get(int page = 1, string key = "")
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                key = "";
            }
            int intPageSize = 50;

            Expression<Func<PM_PLAN_SUB, bool>> whereExpression = a => a.ID > 0;

            return new MessageModel<PageModel<PM_PLAN_SUB>>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_PLAN_SUBServices.QueryPage(whereExpression, page, intPageSize)
            };

        }

        [HttpGet("{id}")]
        public async Task<MessageModel<PM_PLAN_SUB>> Get(int id = 0)
        {
            return new MessageModel<PM_PLAN_SUB>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_PLAN_SUBServices.QueryById(id)
            };
        }

        [HttpPost]
        public async Task<MessageModel<string>> Post([FromBody] PM_PLAN_SUB request)
        {
            var data = new MessageModel<string>();

            var id = await _PM_PLAN_SUBServices.Add(request);
            data.success = id > 0;

            if (data.success)
            {
                data.response = id.ObjToString();
                data.msg = "添加成功";
            }

            return data;
        }

        [HttpPut]
        public async Task<MessageModel<string>> Put([FromBody] PM_PLAN_SUB request)
        {
            var data = new MessageModel<string>();
            if (request.ID > 0)
            {
                data.success = await _PM_PLAN_SUBServices.Update(request);
                if (data.success)
                {
                    data.msg = "更新成功";
                    data.response = request?.ID.ObjToString();
                }
            }

            return data;
        }

        [HttpDelete("{id}")]
        public async Task<MessageModel<string>> Delete(int id = 0)
        {
            var data = new MessageModel<string>();
            if (id > 0)
            {
                var detail = await _PM_PLAN_SUBServices.QueryById(id);

                // detail.IsDeleted = true;

                if (detail != null)
                {
                    data.success = await _PM_PLAN_SUBServices.Update(detail);
                    if (data.success)
                    {
                        data.msg = "删除成功";
                        data.response = detail?.ID.ObjToString();
                    }
                }
            }

            return data;
        }

        #endregion

        #region 根据抽查批次号获取信息
        /// <summary>
        /// 根据抽查批次号获取信息
        /// </summary>
        /// <param name="iCodeNum"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetPmPlanSubByCode(string iCodeNum)
        {
            JObject jo = _PM_PLAN_SUBServices.GetPmPlanSubByCode(iCodeNum);
            return MyResponse.Return<JObject>(jo).GetResult();
        }
        #endregion


    }
}