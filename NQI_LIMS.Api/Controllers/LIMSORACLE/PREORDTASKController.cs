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
    [Authorize(Permissions.Name)]
     public class PREORDTASKController : ControllerBase
        {
             /// <summary>
             /// 服务器接口，因为是模板生成，所以首字母是大写的，自己可以重构下
             /// </summary>
            private readonly IPREORDTASKServices _PREORDTASKServices;
    
            public PREORDTASKController(IPREORDTASKServices PREORDTASKServices)
            {
                _PREORDTASKServices = PREORDTASKServices;
            }
    
            [HttpGet]
            public async Task<MessageModel<PageModel<PREORDTASK>>> Get(int page = 1, string key = "")
            {
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
                {
                    key = "";
                }
                int intPageSize = 50;
    
                Expression<Func<PREORDTASK, bool>> whereExpression = a => a.ORIGREC > 0;
    
                return new MessageModel<PageModel<PREORDTASK>>()
                {
                    msg = "获取成功",
                    success = true,
                    response = await _PREORDTASKServices.QueryPage(whereExpression, page, intPageSize)
                };

    }

    [HttpGet("{id}")]
    public async Task<MessageModel<PREORDTASK>> Get(int id = 0)
    {
        return new MessageModel<PREORDTASK>()
        {
            msg = "获取成功",
            success = true,
            response = await _PREORDTASKServices.QueryById(id)
        };
    }

    [HttpPost]
    public async Task<MessageModel<string>> Post([FromBody] PREORDTASK request)
    {
        var data = new MessageModel<string>();

        var id = await _PREORDTASKServices.Add(request);
        data.success = id > 0;

        if (data.success)
        {
            data.response = id.ObjToString();
            data.msg = "添加成功";
        }

        return data;
    }

    [HttpPut]
    public async Task<MessageModel<string>> Put([FromBody] PREORDTASK request)
    {
        var data = new MessageModel<string>();
        if (request.ORIGREC > 0)
        {
            data.success = await _PREORDTASKServices.Update(request);
            if (data.success)
            {
                data.msg = "更新成功";
                data.response = request?.ORIGREC.ObjToString();
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
            //var detail = await _PREORDTASKServices.QueryById(id);

            //detail.IsDeleted = true;

            //    if (detail != null)
            //    {
            //        data.success = await _PREORDTASKServices.Update(detail);
            //        if (data.success)
            //        {
            //            data.msg = "删除成功";
            //            data.response = detail?.id.ObjToString();
            //        }
            //    }
        }

        return data;
    }
}
}