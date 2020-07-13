using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;

namespace NQI_LIMS.Model.Seed
{
    public class FrameSeed
    {
        #region 生成Controller层
        /// <summary>
        /// 生成Controller层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <param name="isMuti"></param>
        /// <returns></returns>
        public static bool CreateControllers(SqlSugarClient sqlSugarClient, string ConnId = null, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_Controller_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.Api.Controllers", "NQI_LIMS.Api.Controllers", tableNames, "", isMuti);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("************ 生成Controller层 *****************");
                Console.WriteLine(string.Format("Is multi-DataBase: {0}", ex.ToString()));
                return false;
            }

        }
        #endregion

        #region 生成Model层
        /// <summary>
        /// 生成Model层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <param name="isMuti"></param>
        /// <returns></returns>
        public static bool CreateModels(SqlSugarClient sqlSugarClient, string ConnId, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_Model_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.Model", "NQI_LIMS.Model.Models", tableNames, "", isMuti);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region 生成IRepository层
        /// <summary>
        /// 生成IRepository层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateIRepositorys(SqlSugarClient sqlSugarClient, string ConnId, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_IRepository_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.IRepository", "NQI_LIMS.IRepository", tableNames, "", isMuti);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region 生成 IService 层
        /// <summary>
        /// 生成 IService 层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateIServices(SqlSugarClient sqlSugarClient, string ConnId, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_IServices_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.IServices", "NQI_LIMS.IServices", tableNames, "", isMuti);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region 生成 Repository 层 仓储层
        /// <summary>
        /// 生成 Repository 层 仓储层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateRepository(SqlSugarClient sqlSugarClient, string ConnId, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_Repository_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.Repository", "NQI_LIMS.Repository", tableNames, "", isMuti);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region 生成 Service 层
        /// <summary>
        /// 生成 Service 层
        /// </summary>
        /// <param name="sqlSugarClient">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateServices(SqlSugarClient sqlSugarClient, string ConnId, bool isMuti = false, string[] tableNames = null)
        {

            try
            {
                Create_Services_ClassFileByDBTalbe(sqlSugarClient, ConnId, $@"C:\my-file\NQI_LIMS.Services", "NQI_LIMS.Services", tableNames, "", isMuti);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region 根据数据库表生产Controller层
        /// <summary>
        /// 功能描述:根据数据库表生产Controller层
        /// 作　　者:Blog.Core
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        /// <param name="blnSerializable">是否序列化</param>
        private static void Create_Controller_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false,
          bool blnSerializable = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                 .SettingClassTemplate(p => p =
@"using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace " + strNameSpace + @"
{
	[Route(""api/[controller]/[action]"")]
	[ApiController]
    [Authorize(Permissions.Name)]
     public class {ClassName}Controller : ControllerBase
        {
             /// <summary>
             /// 服务器接口，因为是模板生成，所以首字母是大写的，自己可以重构下
             /// </summary>
            private readonly I{ClassName}Services _{ClassName}Services;
    
            public {ClassName}Controller(I{ClassName}Services {ClassName}Services)
            {
                _{ClassName}Services = {ClassName}Services;
            }
    
            [HttpGet]
            public async Task<MessageModel<PageModel<{ClassName}>>> Get(int page = 1, string key = """")
            {
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
                {
                    key = """";
                }
                int intPageSize = 50;
    
                Expression<Func<{ClassName}, bool>> whereExpression = a => a.id > 0;
    
                return new MessageModel<PageModel<{ClassName}>>()
                {
                    msg = ""获取成功"",
                    success = true,
                    response = await _{ClassName}Services.QueryPage(whereExpression, page, intPageSize)
                };

    }

    [HttpGet(""{id}"")]
    public async Task<MessageModel<{ClassName}>> Get(int id = 0)
    {
        return new MessageModel<{ClassName}>()
        {
            msg = ""获取成功"",
            success = true,
            response = await _{ClassName}Services.QueryById(id)
        };
    }

    [HttpPost]
    public async Task<MessageModel<string>> Post([FromBody] {ClassName} request)
    {
        var data = new MessageModel<string>();

        var id = await _{ClassName}Services.Add(request);
        data.success = id > 0;

        if (data.success)
        {
            data.response = id.ObjToString();
            data.msg = ""添加成功"";
        }

        return data;
    }

    [HttpPut]
    public async Task<MessageModel<string>> Put([FromBody] {ClassName} request)
    {
        var data = new MessageModel<string>();
        if (request.id > 0)
        {
            data.success = await _{ClassName}Services.Update(request);
            if (data.success)
            {
                data.msg = ""更新成功"";
                data.response = request?.id.ObjToString();
            }
        }

        return data;
    }

    [HttpDelete(""{id}"")]
    public async Task<MessageModel<string>> Delete(int id = 0)
    {
        var data = new MessageModel<string>();
        if (id > 0)
        {
            var detail = await _{ClassName}Services.QueryById(id);

            detail.IsDeleted = true;

                if (detail != null)
                {
                    data.success = await _{ClassName}Services.Update(detail);
                    if (data.success)
                    {
                        data.msg = ""删除成功"";
                        data.response = detail?.id.ObjToString();
                    }
                }
        }

        return data;
    }
}
}")

                  .ToClassStringList(strNameSpace);
            CreateFilesByClassStringList(ls, strPath, "{0}Controller");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }
        }
        #endregion

        #region 根据数据库表生产Model层

        /// <summary>
        /// 功能描述:根据数据库表生产Model层
        /// 作　　者:NQI_LIMS
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        /// <param name="blnSerializable">是否序列化</param>
        private static void Create_Model_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false,
          bool blnSerializable = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }
            //多库文件分离
            if (isMuti)
            {
                strPath = strPath + @"\Models\" + ConnId;
                //strNameSpace = strNameSpace + "." + ConnId;
                
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                  .SettingClassTemplate(p => p =
@"{using}

namespace " + strNameSpace + @"
{
{ClassDescription}
    [SugarTable( ""{ClassName}"", """ + ConnId + @""")]" + (blnSerializable ? "\n    [Serializable]" : "") + @"
    public class {ClassName}" + (string.IsNullOrEmpty(strInterface) ? "" : (" : " + strInterface)) + @"
    {
        public {ClassName}()
        {
        }
        {PropertyName}
    }
}")
                  .SettingPropertyDescriptionTemplate(p => p = string.Empty)
                  .SettingPropertyTemplate(p => p =
@"{SugarColumn}
           public {PropertyType} {PropertyName} { get; set; }")

                   //.SettingConstructorTemplate(p => p = "              this._{PropertyName} ={DefaultValue};")

                   .ToClassStringList(strNameSpace);

            CreateFilesByClassStringList(ls, strPath, "{0}");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }
        }
        #endregion

        #region 根据数据库表生产IRepository层

        /// <summary>
        /// 功能描述:根据数据库表生产IRepository层
        /// 作　　者:NQI_LIMS
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_IRepository_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }
            //多库文件分离
            if (isMuti)
            {
                strPath = strPath + @"\" + ConnId;
               // strNameSpace = strNameSpace + "." + ConnId;
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                 .SettingClassTemplate(p => p =
@"using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models" + (isMuti ? "." + ConnId + "" : "") + @";
using NQI_LIMS.Model.Models;
namespace " + strNameSpace + @"
{
	/// <summary>
	/// I{ClassName}Repository
	/// </summary>	
    public interface I{ClassName}Repository : IBaseRepository<{ClassName}>" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)) + @"
    {
    }
}")

                  .ToClassStringList(strNameSpace);
            CreateFilesByClassStringList(ls, strPath, "I{0}Repository");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }
        }
        #endregion

        #region 根据数据库表生产IServices层

        /// <summary>
        /// 功能描述:根据数据库表生产IServices层
        /// 作　　者:NQI_LIMS
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_IServices_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }

            //多库文件分离
            if (isMuti)
            {
                strPath = strPath + @"\" + ConnId;
              //  strNameSpace = strNameSpace + "." + ConnId;
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                  .SettingClassTemplate(p => p =
@"using NQI_LIMS.IServices.BASE;
//using NQI_LIMS.Model.Models" + (isMuti ? "." + ConnId + "" : "") + @";
using NQI_LIMS.Model.Models ;
namespace " + strNameSpace + @"
{	
	/// <summary>
	/// I{ClassName}Services
	/// </summary>	
    public interface I{ClassName}Services :IBaseServices<{ClassName}>" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)) + @"
	{
    }
}")

                   .ToClassStringList(strNameSpace);
            CreateFilesByClassStringList(ls, strPath, "I{0}Services");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }

        }
        #endregion

        #region 根据数据库表生产 Repository 层

        /// <summary>
        /// 功能描述:根据数据库表生产 Repository 层
        /// 作　　者:NQI_LIMS
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_Repository_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }

            //多库文件分离
            if (isMuti)
            {
                strPath = strPath + @"\" + ConnId;
                //strNameSpace = strNameSpace + "." + ConnId;
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                  .SettingClassTemplate(p => p =
@"using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository" + (isMuti ? "." + ConnId + "" : "") + @";
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models" + (isMuti ? "." + ConnId + "" : "") + @";
using NQI_LIMS.Repository.Base;

namespace " + strNameSpace + @"
{
	/// <summary>
	/// {ClassName}Repository
	/// </summary>
    public class {ClassName}Repository : BaseRepository<{ClassName}>, I{ClassName}Repository" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)) + @"
    {
        public {ClassName}Repository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}")
                  .ToClassStringList(strNameSpace);


            CreateFilesByClassStringList(ls, strPath, "{0}Repository");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }
        }
        #endregion

        #region 根据数据库表生产 Services 层

        /// <summary>
        /// 功能描述:根据数据库表生产 Services 层
        /// 作　　者:NQI_LIMS
        /// </summary>
        /// <param name="sqlSugarClient"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_Services_ClassFileByDBTalbe(
          SqlSugarClient sqlSugarClient,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {
            //20200706 当表操作的时候，切换数据库好像不起作用，所以添加这个 ConnId
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(ConnId.ToLower());
            }
            //多库文件分离
            if (isMuti)
            {
                strPath = strPath + @"\" + ConnId;
               // strNameSpace = strNameSpace + "." + ConnId;
            }

            var IDbFirst = sqlSugarClient.DbFirst;
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                IDbFirst = IDbFirst.Where(lstTableNames);
            }
            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

                  .SettingClassTemplate(p => p =
@"using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository" + (isMuti ? "." + ConnId + "" : "") + @";
//using NQI_LIMS.IServices" + (isMuti ? "." + ConnId + "" : "") + @";
//using NQI_LIMS.Model.Models" + (isMuti ? "." + ConnId + "" : "") + @";
using NQI_LIMS.Services.BASE;

namespace " + strNameSpace + @"
{
    public partial class {ClassName}Services : BaseServices<{ClassName}>, I{ClassName}Services" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)) + @"
    {
        private readonly I{ClassName}Repository _dal;
        public {ClassName}Services(I{ClassName}Repository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}")
                  .ToClassStringList(strNameSpace);

            CreateFilesByClassStringList(ls, strPath, "{0}Services");

            // 20200706 切回主库
            if (!string.IsNullOrEmpty(ConnId))
            {
                sqlSugarClient.ChangeDatabase(Common.DB.MainDb.CurrentDbConnId.ToLower());
            }
        }
        #endregion

        #region 根据模板内容批量生成文件
        /// <summary>
        /// 根据模板内容批量生成文件
        /// </summary>
        /// <param name="ls">类文件字符串list</param>
        /// <param name="strPath">生成路径</param>
        /// <param name="fileNameTp">文件名格式模板</param>
        private static void CreateFilesByClassStringList(Dictionary<string, string> ls, string strPath, string fileNameTp)
        {

            foreach (var item in ls)
            {
                var fileName = $"{string.Format(fileNameTp, item.Key)}.cs";
                var fileFullPath = Path.Combine(strPath, fileName);
                if (!Directory.Exists(strPath))
                {
                    Directory.CreateDirectory(strPath);
                }
                File.WriteAllText(fileFullPath, item.Value);
            }
        }
        #endregion
    }
}
