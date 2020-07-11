using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NQI_LIMS.Common
{
    public class SearchCondition<T>
    {
        ParameterExpression c = null;
        Expression mCondition = null;

        List<MyExpression> mConditionList = new List<MyExpression>();

        public SearchCondition()
        {
            c = Expression.Parameter(typeof(T), "g");
            //mCondition = new Expression();
        }

        public ParameterExpression GetParameterExpression()
        {
            return c;
        }

        public void AndDatetimeNull(string iFieldName, DateTime iValue, MyOperator iOperator)
        {
            var ex1 = Expression.Property(c, iFieldName);
            var ex2 = Expression.Convert(Expression.Constant(iValue), typeof(T).GetProperty(iFieldName).PropertyType);

            Expression con2 = null;
            switch (iOperator)
            {
                case MyOperator.GreaterThanOrEqual:
                    con2 = Expression.GreaterThanOrEqual(ex1, ex2);
                    break;
                case MyOperator.GreaterThan:
                    con2 = Expression.GreaterThan(ex1, ex2);
                    break;
                case MyOperator.LessThan:
                    con2 = Expression.LessThan(ex1, ex2);
                    break;
                case MyOperator.LessThanOrEqual:
                    con2 = Expression.LessThanOrEqual(ex1, ex2);
                    break;
                case MyOperator.Like:
                    throw new MyException("不支持");
                case MyOperator.Equal:
                    con2 = Expression.Equal(ex1, ex2);
                    break;
                case MyOperator.NotEqual:
                    con2 = Expression.NotEqual(ex1, ex2);
                    break;
                case MyOperator.ListIntContains:
                    throw new MyException("不支持");
                default:
                    break;
            }

            if (con2 != null)
            {
                this.mConditionList.Add(new MyExpression(MyExpressionType.And, con2));
            }
        }

        static Expression MyGreaterThan(Expression e1, Expression e2)
        {
            if (IsNullableType(e1.Type) && !IsNullableType(e2.Type))
                e2 = Expression.Convert(e2, e1.Type);
            else if (!IsNullableType(e1.Type) && IsNullableType(e2.Type))
                e1 = Expression.Convert(e1, e2.Type);
            return Expression.GreaterThan(e1, e2);
        }
        static bool IsNullableType(Type t)
        {
            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public void And(string iFieldName, object iValue, MyOperator iOperator)
        {
            Expression con2 = null;
            switch (iOperator)
            {
                case MyOperator.GreaterThanOrEqual:
                    con2 = Expression.GreaterThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.GreaterThan:
                    con2 = Expression.GreaterThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThan:
                    con2 = Expression.LessThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThanOrEqual:
                    con2 = Expression.LessThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Like:
                    con2 = Expression.Call(Expression.Property(c, typeof(T).GetProperty(iFieldName)), typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Expression.Constant(iValue));
                    break;
                case MyOperator.Equal:
                    con2 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.NotEqual:
                    con2 = Expression.NotEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.ListIntContains:
                    if (iValue is List<int> && (iValue as List<int>).Count > 0)
                    {
                        List<int> values = iValue as List<int>;
                        List<Expression> conList = new List<Expression>();
                        foreach (var item in values)
                        {
                            var con = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(item));

                            conList.Add(con);
                        }

                        if (conList.Count > 1)
                        {
                            con2 = Expression.Or(conList[0], conList[1]);

                            for (int i = 2; i < conList.Count; i++)
                            {
                                con2 = Expression.Or(con2, conList[i]);
                            }
                        }
                        else
                        {
                            con2 = conList[0];
                        }
                    }

                    break;
                case MyOperator.ListIntNotIn:
                    if (iValue is List<int> && (iValue as List<int>).Count > 0)
                    {
                        List<int> values = iValue as List<int>;
                        List<Expression> conList = new List<Expression>();
                        foreach (var item in values)
                        {
                            var con = Expression.NotEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(item));

                            conList.Add(con);
                        }

                        if (conList.Count > 1)
                        {
                            con2 = Expression.And(conList[0], conList[1]);

                            for (int i = 2; i < conList.Count; i++)
                            {
                                con2 = Expression.And(con2, conList[i]);
                            }
                        }
                        else
                        {
                            con2 = conList[0];
                        }
                    }

                    break;
                default:
                    break;
            }

            if (con2 != null)
            {
                this.mConditionList.Add(new MyExpression(MyExpressionType.And, con2));
            }
        }

        public void Or(string iFieldName, object iValue, MyOperator iOperator)
        {
            Expression con2 = null;
            switch (iOperator)
            {
                case MyOperator.GreaterThanOrEqual:
                    con2 = Expression.GreaterThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.GreaterThan:
                    con2 = Expression.GreaterThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThan:
                    con2 = Expression.LessThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThanOrEqual:
                    con2 = Expression.LessThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Like:
                    con2 = Expression.Call(Expression.Property(c, typeof(T).GetProperty(iFieldName)), typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Expression.Constant(iValue));
                    break;
                case MyOperator.NotEqual:
                    con2 = Expression.NotEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Equal:
                    con2 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                default:
                    break;
            }

            if (con2 != null)
            {
                this.mConditionList.Add(new MyExpression(MyExpressionType.Or, con2));
            }
        }

        public Expression CreateOr(string iFieldName, object iValue, MyOperator iOperator)
        {
            Expression con2 = null;
            switch (iOperator)
            {
                case MyOperator.GreaterThanOrEqual:
                    con2 = Expression.GreaterThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.GreaterThan:
                    con2 = Expression.GreaterThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThan:
                    con2 = Expression.LessThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThanOrEqual:
                    con2 = Expression.LessThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Like:
                    con2 = Expression.Call(Expression.Property(c, typeof(T).GetProperty(iFieldName)), typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Expression.Constant(iValue));
                    break;
                case MyOperator.NotEqual:
                    con2 = Expression.NotEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Equal:
                    con2 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                default:
                    break;
            }

            return con2;
        }

        public Expression CreateAnd(string iFieldName, object iValue, MyOperator iOperator)
        {
            Expression con2 = null;
            switch (iOperator)
            {
                case MyOperator.GreaterThanOrEqual:
                    con2 = Expression.GreaterThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.GreaterThan:
                    con2 = Expression.GreaterThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThan:
                    con2 = Expression.LessThan(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.LessThanOrEqual:
                    con2 = Expression.LessThanOrEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.Like:
                    con2 = Expression.Call(Expression.Property(c, typeof(T).GetProperty(iFieldName)), typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Expression.Constant(iValue));
                    break;
                case MyOperator.Equal:
                    con2 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                case MyOperator.NotEqual:
                    con2 = Expression.NotEqual(Expression.Property(c, typeof(T).GetProperty(iFieldName)), Expression.Constant(iValue));
                    break;
                default:
                    break;
            }

            return con2;
        }


        public void Add(Expression iCon)
        {
            this.mConditionList.Add(new MyExpression(MyExpressionType.And, iCon));
        }

        /// <summary>
        /// 新增一个 " And iFieldName == iValue"
        /// </summary>
        /// <param name="iFieldName"></param>
        /// <param name="iValue"></param>
        public void AndEquals(string iFieldName, object iValue)
        {
            Expression con2 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(iFieldName)),
                  Expression.Constant(iValue));
            this.mConditionList.Add(new MyExpression(MyExpressionType.And, con2));
        }

        /// <summary>
        /// 新增一个  " And iFieldName like '%iValue%'"
        /// </summary>
        /// <param name="iFieldName"></param>
        /// <param name="iValue"></param>
        public void AndLike(string iFieldName, string iValue)
        {
            if (!string.IsNullOrEmpty(iValue))
            {
                Expression con = Expression.Call(Expression.Property(c, typeof(T).GetProperty(iFieldName)), typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), Expression.Constant(iValue));

                //mCondition = Expression.And(con, mCondition);

                this.mConditionList.Add(new MyExpression(MyExpressionType.And, con));
            }
        }

        /// <summary>
        /// 新增一个 " And (iFildList[0] = iValueList[0] OR  iFildList[1] = iValueList[1]) …………"
        /// </summary>
        /// <param name="iFieldList"></param>
        /// <param name="iValueList"></param>
        public void AndManyOr(List<string> iFieldList, List<object> iValueList)
        {
            if (iFieldList.IsNullOrEmpty() == false && iValueList.IsNullOrEmpty() == false && iFieldList.Count > 1 && iValueList.Count > 1 && iFieldList.Count == iValueList.Count)
            {
                List<Expression> lst = new List<Expression>();
                for (int i = 0; i < iFieldList.Count; i++)
                {
                    string field = iFieldList[i];
                    object value = iValueList[i];

                    Expression ddd1 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(field)), Expression.Constant(value));
                    lst.Add(ddd1);
                }

                Expression con = Expression.Or(lst[0], lst[1]);

                for (int i = 2; i < lst.Count; i++)
                {
                    con = Expression.Or(con, lst[i]);
                }

                this.mConditionList.Add(new MyExpression(MyExpressionType.And, con));
            }
        }

        /// <summary>
        /// 新增一个 " And (iFildList[0] = iValueList[0] OR  iFildList[1] = iValueList[1]) …………"
        /// </summary>
        /// <param name="iFieldList"></param>
        /// <param name="iValueList"></param>
        public void AndManyOr(string[] iFieldList, object[] iValueList)
        {
            if (iFieldList != null && iValueList != null && iFieldList.Length > 1 && iValueList.Length > 1 && iFieldList.Length == iValueList.Length)
            {
                List<Expression> lst = new List<Expression>();
                for (int i = 0; i < iFieldList.Length; i++)
                {
                    string field = iFieldList[i];
                    object value = iValueList[i];

                    Expression ddd1 = Expression.Equal(Expression.Property(c, typeof(T).GetProperty(field)), Expression.Constant(value));
                    lst.Add(ddd1);
                }

                Expression con = Expression.Or(lst[0], lst[1]);

                for (int i = 2; i < lst.Count; i++)
                {
                    con = Expression.Or(con, lst[i]);
                }

                this.mConditionList.Add(new MyExpression(MyExpressionType.And, con));
            }
        }

        /// <summary>
        /// 获取最终条件结果
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, bool>> GetCondition()
        {
            if (this.mConditionList != null && this.mConditionList.Count > 0)
            {
                this.mCondition = this.mConditionList[0].Expression;
                for (int i = 1; i < this.mConditionList.Count; i++)
                {
                    var item = this.mConditionList[i];

                    switch (item.Type)
                    {
                        case MyExpressionType.And:
                            this.mCondition = Expression.And(this.mCondition, item.Expression);
                            break;
                        case MyExpressionType.Or:
                            this.mCondition = Expression.And(this.mCondition, item.Expression);
                            break;
                        default:
                            this.mCondition = Expression.And(this.mCondition, item.Expression);
                            break;
                    }
                }
            }
            else
            {
                this.mCondition = Expression.Constant(true);
            }

            Expression<Func<T, bool>> end = Expression.Lambda<Func<T, bool>>(mCondition, new ParameterExpression[] { c });
            return end;
            //Expression<Func<T, bool>> end = Expression.Lambda<Func<T, bool>>(mCondition, new ParameterExpression[] { c });

            //for (int i = 1; i < this.mConditionList.Count; i++)
            //{
            //    var item = this.mConditionList[i];
            //    if (item.Type == MyExpressionType.And)
            //    {
            //        end = Expression.Lambda<Func<T, bool>>(Expression.And(end.Body, item.Expression), new ParameterExpression[] { c });
            //    }
            //    else
            //    {
            //        end = Expression.Lambda<Func<T, bool>>(Expression.Or(end.Body, item.Expression), new ParameterExpression[] { c });
            //    }
            //}

            //return end;
        }
    }

    public enum MyExpressionType
    {
        /// <summary>
        /// %%
        /// </summary>
        And = 1,
        /// <summary>
        /// ||
        /// </summary>
        Or = 2,
    }

    public enum MyOperator
    {
        Like = 0,
        /// <summary>
        /// ==
        /// </summary>
        Equal = 1,
        /// <summary>
        /// >=
        /// </summary>
        GreaterThanOrEqual = 3,
        /// <summary>
        /// >
        /// </summary>
        GreaterThan = 4,
        /// <summary>
        /// <
        /// </summary>
        LessThan = 5,
        /// <summary>
        /// <=
        /// </summary>
        LessThanOrEqual = 6,
        /// <summary>
        /// <>
        /// </summary>
        NotEqual = 7,
        /// <summary>
        /// in List<int>
        /// </summary>
        ListIntContains = 8,

        /// <summary>
        /// not in List<int>
        /// </summary>
        ListIntNotIn = 9,
    }
    class MyExpression
    {
        public MyExpressionType Type;
        public Expression Expression;

        public MyExpression(MyExpressionType iType, Expression iExpression)
        {
            this.Type = iType;
            this.Expression = iExpression;
        }
    }
}
