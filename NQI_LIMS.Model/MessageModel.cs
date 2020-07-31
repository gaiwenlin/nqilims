using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NQI_LIMS.Model
{
    /// <summary>
    /// 通用返回信息类
    /// </summary>
    public class MessageModel<T>
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int status { get; set; } = 0;
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool success { get; set; } = false;
        /// <summary>
        /// 返回信息
        /// </summary>
        public string msg { get; set; } = "";
        /// <summary>
        /// 返回数据集合
        /// </summary>
        public T response { get; set; }

        public ObjectResult GetResult()
        {

            return new ObjectResult(JsonConvert.SerializeObject(this));
        }

    }

    public class MyResponse
    {
        public static MessageModel<T> Return<T>(T iData, string iHintInfo = "")
        {
            MessageModel<T> result = new MessageModel<T>();
            result.status = (int)ResponseResult.Success;
            result.msg = iHintInfo;
            result.response = iData;
            return result;
        }

        static MessageModel<T> ToYou<T>(T iData, int iStatusCodes,string iHintInfo = "")
        {
            MessageModel<T> result = new MessageModel<T>();
            result.status = iStatusCodes;
            result.success = false;
            result.msg = iHintInfo;
            result.response = iData;
            return result;
        }

        public static MessageModel<T> MustLogin<T>()
        {
            return ToYou(default(T), (int)ResponseResult.MustLogin, "未登录或登录超时，请重新登录");
        }
    }

    public enum ResponseResult
    {
        /// <summary>
        /// 未知错误类型
        /// </summary>
        None = -1,
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0,
        /// <summary>
        /// 需要重新登录
        /// </summary>
        MustLogin = 1,
        /// <summary>
        /// 业务规则错误信息
        /// </summary>
        BusinessError = 2,
        /// <summary>
        /// 无操作权限
        /// </summary>
        NoAuth = 3

    }
}
