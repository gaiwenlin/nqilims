using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Data;

namespace NQI_LIMS.Common
{
    /// <summary>
    /// add_by_weiguohua
    /// </summary>
    public static class ExtensionMethods
    {
        #region DataTable扩展
        /// <summary>
        /// 新增一个列
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        public static void AddDataColumn(this DataTable dt, string columnName)
        {
            if (dt != null && dt.Columns.Contains(columnName) == false)
            {
                dt.Columns.Add(columnName);
            }
        }

        /// <summary>
        /// 新增很多列
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnNames"></param>
        public static void AddDateColumns(this DataTable dt, string[] columnNames)
        {
            foreach (var item in columnNames)
            {
                dt.AddDataColumn(item);
            }
        }

        public static void AddDateRowsFromStringArray(this DataTable dt, string[] rowContents)
        {
            DataRow row = dt.NewRow();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                row[i] = rowContents.GetStringArrayContent(i);
            }

            dt.Rows.Add(row);
        }

        public static string GetStringArrayContent(this string[] strArray, int i)
        {
            if (strArray != null && strArray.Length >= i)
            {
                return strArray[i];
            }

            return "";
        }
        #endregion

        public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();

            DataColumn[] dataColumns = new DataColumn[props.Count()];

            for (int i = 0; i < props.Count(); i++)
            {
                Type type = props[i].PropertyType;

                //当类型为Nullable<>时
                if ((type.IsGenericType) && (type.GetGenericTypeDefinition() == typeof(Nullable<>)))
                {
                    type = type.GetGenericArguments()[0];
                }

                var dc = new DataColumn(props[i].Name, type);

                dataColumns[i] = dc;
            }

            var dt = new DataTable();
            dt.TableName = "steet1";
            //dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            dt.Columns.AddRange(dataColumns);
            if (collection.Count() > 0)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(collection.ElementAt(i), null);

                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }

        public static string DateTimeToString(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string DateTimeToString(this DateTime? dt)
        {
            if (dt != null)
            {
                return Convert.ToDateTime(dt).ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                return "";
            }
        }

        public static string DateTimeToDateString(this DateTime? dt)
        {
            if (dt != null)
            {
                return Convert.ToDateTime(dt).ToString("yyyy-MM-dd");
            }
            else
            {
                return "";
            }
        }

        #region 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
        /// <summary>

        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母

        /// </summary>

        /// <param name="CnChar">单个汉字</param>

        /// <returns>单个大写字母</returns>

        public static string GetCharSpellCode(this string CnChar)
        {

            if (!string.IsNullOrEmpty(CnChar))
            {
                CnChar = CnChar.Substring(0, 1);
            }

            long iCnChar;

            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回首字母

            if (ZW.Length == 1)
            {

                //return CommonMethod.CutString(CnChar.ToUpper(), 1);
                return CnChar.ToUpper().Substring(0, 1);

            }
            else
            {

                // get the array of byte from the single char

                int i1 = (short)(ZW[0]);

                int i2 = (short)(ZW[1]);

                iCnChar = i1 * 256 + i2;

            }

            // iCnChar match the constant

            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {

                return "A";

            }

            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {

                return "B";

            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {

                return "C";

            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {

                return "D";

            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {

                return "E";

            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {

                return "F";

            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {

                return "G";

            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {

                return "H";

            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {

                return "J";

            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {

                return "K";

            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {

                return "L";

            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {

                return "M";

            }
            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {

                return "N";

            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {

                return "O";

            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {

                return "P";

            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {

                return "Q";

            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {

                return "R";

            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {

                return "S";

            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {

                return "T";

            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {

                return "W";

            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {

                return "X";

            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {

                return "Y";

            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {

                return "Z";

            }
            else

                return ("?");

        }
        #endregion

        #region ToJOject
        public static JObject ToJObjectJson(this object iValue)
        {
            return JObject.Parse(JsonConvert.SerializeObject(iValue));
        }
        #endregion

        #region ToJArray
        public static JArray ToJArrayJson(this object iList)
        {
            return JArray.Parse(JsonConvert.SerializeObject(iList));
        }
        #endregion

        #region 自动抛异常
        public static void ThrowException(this bool iValue, string iErrorMsg)
        {
            if (iValue)
            {
                throw new MyException(iErrorMsg);
            }
        }
        #endregion

        #region 字符串转List<int>
        /// <summary>
        /// 字符串转List<int>
        /// </summary>
        /// <param name="iListStr"></param>
        /// <returns></returns>
        public static List<int> GetSearchIntList(this string iListStr)
        {
            List<int> rt = new List<int>();

            if (!string.IsNullOrEmpty(iListStr))
            {
                var array = iListStr.Split(',');

                foreach (var item in array)
                {
                    int value = 0;

                    if (int.TryParse(item, out value))
                    {
                        rt.Add(value);
                    }
                }
            }

            return rt;
        }

        #endregion

        #region 字符串转List<long>
        /// <summary>
        /// 字符串转List<int>
        /// </summary>
        /// <param name="iListStr"></param>
        /// <returns></returns>
        public static List<long> GetSearchLongList(this string iListStr)
        {
            List<long> rt = new List<long>();

            if (!string.IsNullOrEmpty(iListStr))
            {
                var array = iListStr.Split(',');

                foreach (var item in array)
                {
                    long value = 0;

                    if (long.TryParse(item, out value))
                    {
                        rt.Add(value);
                    }
                }
            }

            return rt;
        }

        #endregion

        #region 字符串转List<string>
        /// <summary>
        /// 字符串转List<int>
        /// </summary>
        /// <param name="iListStr"></param>
        /// <returns></returns>
        public static List<string> GetSearchStringList(this string iListStr)
        {
            List<string> rt = new List<string>();

            if (!string.IsNullOrEmpty(iListStr))
            {
                var array = iListStr.Split(',');

                foreach (var item in array)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        rt.Add(item);
                    }
                }
            }

            return rt;
        }

        #endregion

        #region 搜索时格式化值
        #region 搜索时格式化Int
        /// <summary>
        /// 搜索时格式化Int
        /// </summary>
        /// <param name="iIntStr"></param>
        /// <returns></returns>
        public static int GetSearchInt(this string iIntStr)
        {
            if (!string.IsNullOrEmpty(iIntStr))
            {
                int i = int.MinValue;

                if (int.TryParse(iIntStr, out i))
                {
                    return i;
                }
            }

            return int.MinValue;
        }
        #endregion

        #region 搜索时格式化Int
        /// <summary>
        /// 搜索时格式化Int
        /// </summary>
        /// <param name="iIntStr"></param>
        /// <returns></returns>
        public static decimal GetSearchDecimal(this string iStr)
        {
            if (!string.IsNullOrEmpty(iStr))
            {
                decimal i = decimal.MinValue;

                if (decimal.TryParse(iStr, out i))
                {
                    return i;
                }
            }

            return decimal.MinValue;
        }
        #endregion

        #region 搜索时格式化开始时间
        /// <summary>
        /// 搜索时格式化开始时间
        /// </summary>
        /// <param name="iStart"></param>
        /// <returns></returns>
        public static string GetSearchStartTime(this string iStart)
        {
            if (!string.IsNullOrEmpty(iStart))
            {
                DateTime start = DateTime.Now;

                if (DateTime.TryParse(iStart, out start))
                {
                    return start.ToString("yyyy-MM-dd 00:00:00");
                }
            }

            return "";
        }
        #endregion
        /// <summary>
        /// 搜索时格式化开始时间(时期)
        /// </summary>
        /// <param name="iStart"></param>
        /// <returns></returns>
        public static string GetSearchShortTime(this string iStart)
        {
            if (!string.IsNullOrEmpty(iStart))
            {
                DateTime start = DateTime.Now;

                if (DateTime.TryParse(iStart, out start))
                {
                    return start.ToString("yyyy-MM-dd");
                }
            }

            return "";
        }

        #region 搜索时格式化开始结束时间
        /// <summary>
        /// 搜索时格式化开始结束时间
        /// </summary>
        /// <param name="iEnd"></param>
        /// <returns></returns>
        public static string GetSearchEndTime(this string iEnd)
        {
            if (!string.IsNullOrEmpty(iEnd))
            {
                DateTime end = DateTime.Now;

                if (DateTime.TryParse(iEnd, out end))
                {
                    return end.ToString("yyyy-MM-dd 23:59:59");
                }
            }

            return "";
        }
        #endregion

        #region String to Datetime？
        public static DateTime? StringToDateTime2(this string iStart)
        {
            DateTime? time = null;
            if (!string.IsNullOrEmpty(iStart))
            {
                DateTime start = DateTime.Now;

                if (DateTime.TryParse(iStart, out start))
                {
                    time = start;
                }
            }

            return time;
        }
        #endregion

        public static bool IsDateTime(this string iDateTime)
        {
            DateTime dt = DateTime.Now;

            if (DateTime.TryParse(iDateTime, out dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region 不允许为空
        public static void NotAllowNull(this object obj, string hintMsg)
        {
            if (obj == null)
            {
                throw new MyException(string.Format("{0}", hintMsg));
            }
        }
        #endregion

        #region List是否为空或者count=0
        public static bool IsNullOrEmpty<T>(this List<T> ilist)
        {
            if (ilist == null || ilist.Count == 0)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region List<T> to JArray
        public static JArray ToJArray<T>(this List<T> ilist)
        {
            if (ilist.IsNullOrEmpty())
            {
                return new JArray();
            }
            else
            {
                return JArray.Parse(JsonConvert.SerializeObject(ilist));
            }
        }
        #endregion

        public static string GetNotNullString(this string str)
        {
            return string.IsNullOrEmpty(str) ? "" : str;
        }

        #region 字符串非空
        public static void NotAllowNullOrEmpty(this string str, string hintMsg, bool customMsg = false)
        {
            if (string.IsNullOrEmpty(str) && customMsg == false)
            {
                throw new MyException(string.Format("请正确填写{0}信息", hintMsg));
            }
            else if (string.IsNullOrEmpty(str) && customMsg == true)
            {
                throw new MyException(string.Format("{0}", hintMsg));
            }
        }

        public static void NotAllowNullOrEmpty(this string str, string hintMsg, int iStringSize, bool customMsg = false)
        {
            if (string.IsNullOrEmpty(str) && customMsg == false)
            {
                throw new MyException(string.Format("请正确填写{0}信息", hintMsg));
            }
            else if (string.IsNullOrEmpty(str) && customMsg == true)
            {
                throw new MyException(string.Format("{0}", hintMsg));
            }

            if (str.Length > iStringSize && customMsg == false)
            {
                throw new MyException(string.Format("{0}长度最大{1}个字符", hintMsg, iStringSize));
            }
            else if (str.Length > iStringSize && customMsg == true)
            {
                throw new MyException(string.Format("{0},长度最大{1}个字符", hintMsg, iStringSize));
            }
        }
        #endregion

        #region 手机号码是否正确

        /// <summary>
        /// 验证手机号码格式是否正确
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="hintMsg"></param>
        public static void IsPhone(this string phone, string hintMsg = "")
        {
            if (!Regex.IsMatch(phone, @"^[1]+\d{10}"))
            {
                hintMsg = string.IsNullOrEmpty(hintMsg) ? "手机号码格式不对！" : hintMsg;
                throw new MyException(hintMsg);
            }
        }

        /// <summary>
        /// 验证手机号码格式是否正确
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="hintMsg"></param>
        public static bool IsPhoneReturn(this string phone)
        {
            return Regex.IsMatch(phone, @"^[1]+\d{10}");
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jObject"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static JObject SetProperty<T>(this JObject jObject, string property, T value)
        {
            if (value == null)
            {
                jObject[property] = JToken.FromObject("");
            }
            else
            {
                jObject[property] = JToken.FromObject((T)value);
            }
            return jObject;
        }
        /// <summary>
        /// 合并2个JObject
        /// </summary>
        /// <param name="jObject"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        public static JObject ConcatJObject(this JObject jObject, JObject objValue)
        {
            if (objValue == null)
            {
                return jObject;
            }

            foreach (var item in objValue)
            {
                jObject[item.Key] = item.Value;
            }
            return jObject;
        }

        public static JArray ConcatJArray(this JArray jarray, JArray insertObj)
        {
            if (insertObj == null || insertObj.Count == 0)
            {
                return jarray;
            }

            foreach (JObject item in insertObj)
            {
                jarray.Add(item);
            }

            return jarray;
        }

        /// <summary>
        /// 在jarry数组前插入元素
        /// </summary>
        /// <param name="jarray"></param>
        /// <param name="insertObj"></param>
        /// <returns></returns>
        public static JArray InsertTop(this JArray jarray, JObject insertObj)
        {
            if (insertObj == null)
            {
                return jarray;
            }

            JArray rt = new JArray();

            rt.Add(insertObj);

            foreach (var item in jarray)
            {
                rt.Add(item);
            }

            return jarray;

        }

        /// <summary>
        /// 获取某个对象的属性值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="propertyname"></param>
        /// <returns></returns>
        public static string GetPropertyValue<T>(this T t, string propertyname)
        {
            Type type = typeof(T);

            PropertyInfo property = type.GetProperty(propertyname);

            if (property == null) return String.Empty;

            object o = property.GetValue(t, null);

            if (o == null) return String.Empty;

            return o.ToString();
        }

        /// 把 DataRow 转换成 Model实例 并返回 实例的 Json string 
        public static T ToModelInfoOf<T>(this DataRow modelDr)
        {
            var type = typeof(T);
            var t = (T)Activator.CreateInstance(type);
            var properties = type.GetProperties();
            System.IFormatProvider format = new System.Globalization.CultureInfo("zh-cn", true);
            foreach (var propertyInfo in properties)
            {
                try //有些列不需要返回到客户端,因此在返回的dataset里 没有这些列,用这个通用的方法去访问这个列的值会有异常,只需捕捉就行
                {
                    var value = modelDr[propertyInfo.Name];

                    if (value != DBNull.Value)
                    {
                        if (propertyInfo.PropertyType == typeof(DateTime))
                        {
                            propertyInfo.SetValue(t,
                                value == DBNull.Value ? DateTime.MinValue : DateTime.Parse(value.ToString(), format), null);
                        }
                        else if (propertyInfo.PropertyType == typeof(int))
                        {
                            propertyInfo.SetValue(t, int.Parse(value.ToString()), null);
                        }
                        else if (propertyInfo.PropertyType == typeof(decimal))
                        {
                            propertyInfo.SetValue(t, decimal.Parse(value.ToString()), null);
                        }
                        else if (propertyInfo.PropertyType == typeof(JArray))
                        {
                            propertyInfo.SetValue(t, JArray.Parse(value.ToString()), null);
                        }
                        else
                        {
                            propertyInfo.SetValue(t, value, null);
                        }
                    }
                }
                catch
                {

                }
            }
            return t;
        }

        /// <summary>
        /// 从一个JObject里获取对应属性的值.返回值里会被顾虑关键字,比如防止sql注入,javascript,敏感词等等
        /// </summary>
        /// <typeparam name="T">要返回的数据类型,默认是string</typeparam>
        /// <param name="jo">要从哪个JObject里获取值</param>
        /// <param name="token">当前JObject的某个属性</param>
        /// <param name="caseSensitive">token的名称是否区分大小写,比如 A a,默认不区分大小写</param>
        /// <param name="defaultValue">如果要查找的属性不存在,需要什么样的默认值</param>
        /// <returns>返回这个T类型的数据</returns>
        public static T GetValueExt<T>(this JObject jo, string token, T defaultValue = default(T), bool caseSensitive = false)
        {
            T t;
            try
            {
                //判断当前jo是否含有 token对应的属性
                var curPro =
                    jo.Properties()
                        .FirstOrDefault(x => String.Equals(x.Name, token, StringComparison.CurrentCultureIgnoreCase));
                if (caseSensitive)
                {
                    curPro =
                    jo.Properties()
                        .FirstOrDefault(x => String.Equals(x.Name, token));
                }
                if (curPro == null) //没有这个token
                {

                    t = defaultValue;
                }
                else
                {
                    try
                    {
                        t = (T)Convert.ChangeType(jo.Value<T>(curPro.Name), typeof(T), CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        t = defaultValue;
                    }
                    //if (t.GetType().Name == "String")
                    //{
                    //    foreach (var item in Commons.errWords)
                    //    {
                    //        if (t.ToString().ToLower().IndexOf(item) > -1)
                    //        {
                    //            t = defaultValue;
                    //            break;
                    //        }
                    //    }
                    //}
                    //if (t.GetType() == typeof(decimal))
                    //{
                    //    var val = double.Parse(t.ToString());
                    //    //t = (T)(Object)Math.Round(val, 2);
                    //}
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return t;
        }

        /// <summary>
        /// 从一个JObject里获取对应属性的值.返回值里会被顾虑关键字,比如防止sql注入,javascript,敏感词等等
        /// </summary>
        /// <param name="jo">要返回的数据类型,默认是string</param>
        /// <param name="token">要从哪个JObject里获取值</param>
        /// <param name="caseSensitive">token的名称是否区分大小写,比如 A a,默认不区分大小写</param>
        /// <param name="defaultValue">如果要查找的属性不存在,需要什么样的默认值</param>
        /// <param name="bMaskKeyWord">是否需要进行关键字过滤,默认是需要</param>
        /// <param name="dicFile">对于获取string类型的值,可以传一个字典地址来过滤敏感词,关键字</param>
        /// <returns>返回找到的数据</returns>
        public static string GetValueExt(this JObject jo, string token, string defaultValue = "",
            bool caseSensitive = false, bool bMaskKeyWord = true, string dicFile = "")
        {
            var ret = GetValueExt<string>(jo, token, defaultValue, caseSensitive);
            ret = string.IsNullOrEmpty(ret) ? "" : ret.Trim();
            if (!bMaskKeyWord)
            {
                return ret;
            }

            return ret;

        }







        /// <summary>
        /// 把dataset的中数据列的值直接转不需要再判断DBNull.Value了
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <param name="colName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T GetValue<T>(this DataRow row, string colName, T defaultValue = default(T))
        {
            var ret = defaultValue;
            if (row.Table.Columns[colName] == null)
            {
                return ret;
            }
            if (row[colName] == DBNull.Value)
            {
                return ret;
            }
            ret = (T)Convert.ChangeType(row[colName], typeof(T));
            return ret;
        }

        /// <summary>
        ///  默认返回string
        /// </summary>
        /// <param name="row"></param>
        /// <param name="colName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetValue(this DataRow row, string colName, string defaultValue = "")
        {
            return GetValue<string>(row, colName, string.Empty);
        }


        //added by ldf 01242018
        /// <summary>
        /// 把一个DataRow 转换成一个对象实例
        /// </summary>
        /// <param name="dr">DataRow</param>
        /// <returns>返回一个T 类型的实例</returns>
        public static T ToInstanceOf<T>(this DataRow dr) where T : new()
        {
            var ret = Activator.CreateInstance<T>();
            var props = ret.GetType().GetProperties();

            foreach (PropertyInfo pi in props)
            {
                var piType = pi.PropertyType.ToString().ToLower();

                switch (piType)
                {
                    case "system.datetime":
                        pi.SetValue(ret, dr.GetValue<DateTime>(pi.Name));
                        break;
                    case "system.string":
                        pi.SetValue(ret, dr.GetValue(pi.Name));
                        break;
                    case "system.byte":
                        pi.SetValue(ret, dr.GetValue<bool>(pi.Name));
                        break;
                    case "system.int16":
                    case "system.int32":
                    case "system.int64":
                        pi.SetValue(ret, dr.GetValue<int>(pi.Name));
                        break;
                    case "system.decimal":
                        pi.SetValue(ret, dr.GetValue<decimal>(pi.Name));
                        break;
                    case "system.boolean":
                        var val = dr.GetValue<int>(pi.Name);
                        if (val == 1)
                        {
                            pi.SetValue(ret, true);
                        }
                        else
                        {
                            pi.SetValue(ret, false);
                        }
                        break;

                    default:
                        pi.SetValue(ret, Activator.CreateInstance(pi.PropertyType));
                        break;
                }
            }

            return ret;
        }


        /// <summary>
        /// 把一个datarow集合转换成对应对象的JArray
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="drs"></param>
        /// <returns></returns>
        public static JArray ToJArrayOf<T>(this DataRow[] drs) where T : new()
        {
            var lst = new List<T>();
            foreach (DataRow dr in drs)
            {
                lst.Add(dr.ToInstanceOf<T>());
            }
            return JArray.FromObject(lst);
        }
    }
}
