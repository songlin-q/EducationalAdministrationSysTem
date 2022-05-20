using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EducationalAdministrationSystem.API.Common.ConvertHelper
{
    public class JsonAndList
    {


        #region 序列化
        // 将对象(包含集合对象)序列化为Json
        public static string SerializeObjToJson(object obj)
        {
            string strRes = string.Empty;
            try
            {
                strRes = JsonConvert.SerializeObject(obj);
            }
            catch
            { }
            return strRes;
        }
        public static string SerializeObjToJson_GuoLvKongZhi(object obj)
        {
            string strRes = string.Empty;
            try
            {

                JsonSerializerSettings jss = new JsonSerializerSettings();
                jss.NullValueHandling = NullValueHandling.Ignore;
                strRes = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, jss);

            }
            catch
            { }

            return strRes;
        }

        //将xml转换为json
        public static string SerializeXmlToJson(System.Xml.XmlNode node)
        {
            string strRes = string.Empty;
            try
            {
                strRes = JsonConvert.SerializeXmlNode(node);
            }
            catch
            { }

            return strRes;
        }

        //支持Linq格式的xml转换
        public static string SerializeXmlToJson(System.Xml.Linq.XNode node)
        {
            string strRes = string.Empty;
            try
            {
                strRes = JsonConvert.SerializeXNode(node);
            }
            catch
            { }

            return strRes;
        }
        #endregion

        /// <summary>
        /// 将XML转换成Json对象
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string Xml2Json(string xml)
        {
            // string xml = "<Test><Name>Test class</Name><X>100</X><Y>200</Y></Test>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);

            return json;

        }


        #region 反序列化
        //将json反序列化为实体对象(包含DataTable和List<>集合对象)
        public static T DeserializeJsonToObj<T>(string strJson)
        {
            T oRes = default(T);
            try
            {
                oRes = JsonConvert.DeserializeObject<T>(strJson);
            }
            catch (Exception ee)
            { }

            return oRes;
        }

        //将Json数组转换为实体集合
        public static List<T> JsonLstToObjs<T>(List<string> lstJson)
        {
            List<T> lstRes = new List<T>();
            try
            {
                foreach (var strObj in lstJson)
                {
                    //将json反序列化为对象
                    var oRes = JsonConvert.DeserializeObject<T>(strObj);
                    lstRes.Add(oRes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstRes;
        }


        public static List<T> JsonLstToObjs<T>(string lstJson)
        {

            try
            {

                //将json反序列化为对象
                return JsonConvert.DeserializeObject<List<T>>(lstJson);

            }
            catch (Exception ex)
            {
                return null;
            }

        }






        public static string JObjToString(JObject jObj, string keyName)
        {
            if (jObj[keyName] != null)
            {
                return jObj[keyName].ToString();
            }
            else
            {
                return null;
            }
        }

        public static JObject JsonToJObject(string json)
        {
            return JsonConvert.DeserializeObject(json) as JObject;
        }



        #endregion
    }
}
