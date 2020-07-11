using System;
using System.Collections.Generic;
using System.Text;

namespace NQI_LIMS.Common
{
    /// <summary>
    /// 自定义异常add_by_weiguohua
    /// </summary>
   public class MyException : ApplicationException
    {
        public int status = 400;
        public object data = null;

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }

        public MyException(string message, int responseId = 400, object data = null)
            : base(message)
        {
            this.status = responseId;
            this.data = data;
        }
    }
}
