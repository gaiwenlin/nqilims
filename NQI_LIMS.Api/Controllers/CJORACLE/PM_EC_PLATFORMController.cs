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
    /// <summary>
    /// 网点信息控制类
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Permissions.Name)]
    public class PM_EC_PLATFORMController : ControllerBase
    {
        /// <summary>
        /// 服务器接口，因为是模板生成，所以首字母是大写的，自己可以重构下
        /// </summary>
        private readonly IPM_EC_PLATFORMServices _PM_EC_PLATFORMServices;

        public PM_EC_PLATFORMController(IPM_EC_PLATFORMServices PM_EC_PLATFORMServices)
        {
            _PM_EC_PLATFORMServices = PM_EC_PLATFORMServices;
        }

        [HttpGet]
        public async Task<MessageModel<PageModel<PM_EC_PLATFORM>>> Get(int page = 1, string key = "")
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                key = "";
            }
            int intPageSize = 50;

            Expression<Func<PM_EC_PLATFORM, bool>> whereExpression = a => a.EC_ID > 0;

            return new MessageModel<PageModel<PM_EC_PLATFORM>>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_EC_PLATFORMServices.QueryPage(whereExpression, page, intPageSize)
            };

        }

        [HttpGet("{id}")]
        public async Task<MessageModel<PM_EC_PLATFORM>> Get(int id = 0)
        {
            return new MessageModel<PM_EC_PLATFORM>()
            {
                msg = "获取成功",
                success = true,
                response = await _PM_EC_PLATFORMServices.QueryById(id)
            };
        }

        [HttpPost]
        public async Task<MessageModel<string>> Post([FromBody] PM_EC_PLATFORM request)
        {
            var data = new MessageModel<string>();

            var id = await _PM_EC_PLATFORMServices.Add(request);
            data.success = id > 0;

            if (data.success)
            {
                data.response = id.ObjToString();
                data.msg = "添加成功";
            }

            return data;
        }

        [HttpPut]
        public async Task<MessageModel<string>> Put([FromBody] PM_EC_PLATFORM request)
        {
            var data = new MessageModel<string>();
            if (request.EC_ID > 0)
            {
                data.success = await _PM_EC_PLATFORMServices.Update(request);
                if (data.success)
                {
                    data.msg = "更新成功";
                    data.response = request?.EC_ID.ObjToString();
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
                var detail = await _PM_EC_PLATFORMServices.QueryById(id);

                //detail.IsDeleted = true;

                if (detail != null)
                {
                    data.success = await _PM_EC_PLATFORMServices.Update(detail);
                    if (data.success)
                    {
                        data.msg = "删除成功";
                        data.response = detail?.EC_ID.ObjToString();
                    }
                }
            }

            return data;
        }
    }
}