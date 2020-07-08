using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NQI_LIMS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   // [Authorize(Permissions.Name)]
    public class PM_PLANController : ControllerBase
    {
        /// <summary>
        /// 服务器接口，因为是模板生成，所以首字母是大写的，自己可以重构下
        /// </summary>
        private readonly IPM_PLANServices _PM_PLANServices;

        public PM_PLANController(IPM_PLANServices PM_PLANServices)
        {
            _PM_PLANServices = PM_PLANServices;
        }

        [HttpGet]
        public async Task<MessageModel<PageModel<PM_PLAN>>> Get(int page = 1, string key = "")
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                key = "";
            }
            int intPageSize = 50;

            Expression<Func<PM_PLAN, bool>> whereExpression = a => a.ID > 0;

            return new MessageModel<PageModel<PM_PLAN>>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_PLANServices.QueryPage(whereExpression, page, intPageSize)
            };

        }

        [HttpGet("{id}")]
        public async Task<MessageModel<PM_PLAN>> Get(int id = 0)
        {
            return new MessageModel<PM_PLAN>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_PLANServices.QueryById(id)
            };
        }

        [HttpPost]
        public async Task<MessageModel<string>> Post([FromBody] PM_PLAN request)
        {
            var data = new MessageModel<string>();

            var id = await _PM_PLANServices.Add(request);
            data.success = id > 0;

            if (data.success)
            {
                data.response = id.ObjToString();
                data.msg = "添加成功";
            }

            return data;
        }

        [HttpPut]
        public async Task<MessageModel<string>> Put([FromBody] PM_PLAN request)
        {
            var data = new MessageModel<string>();
            if (request.ID > 0)
            {
                data.success = await _PM_PLANServices.Update(request);
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
                var detail = await _PM_PLANServices.QueryById(id);

                //detail.IsDeleted = true;

                if (detail != null)
                {
                    data.success = await _PM_PLANServices.Update(detail);
                    if (data.success)
                    {
                        data.msg = "删除成功";
                        data.response = detail?.ID.ObjToString();
                    }
                }
            }

            return data;
        }
    }
}