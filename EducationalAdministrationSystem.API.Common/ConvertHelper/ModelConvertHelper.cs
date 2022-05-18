using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSystem.API.Common.ConvertHelper
{
    public class ModelConvertHelper<T> where T : new()
    {

        /// <summary>
        /// 将DataTable转换为对象集合
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="isNeedRemoveSpace">是否需要去除列中的空格</param>
        /// <returns></returns>
        public static IList<T> ConvertToModel(DataTable dt, bool isNeedRemoveSpace)
        {

            IList<T> ts = new List<T>();// 定义集合
            Type type = typeof(T); // 获得此模型的类型
            string tempName = "";

            if (isNeedRemoveSpace == true)
            {

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var tmpcolName = dt.Columns[i].ColumnName;
                    dt.Columns[i].ColumnName = tmpcolName.Trim();
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;
                    if (dt.Columns.Contains(tempName))
                    {
                        if (!pi.CanWrite) continue;
                        object value = dr[tempName];
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                ts.Add(t);
            }
            return ts;
        }
    }
}
