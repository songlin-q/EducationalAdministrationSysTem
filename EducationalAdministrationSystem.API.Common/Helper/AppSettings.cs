using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSystem.API.Common.Helper
{
    /// <summary>
    /// 配置文件的操作类
    /// </summary>
    public class AppSettings
    {
        static IConfiguration _configuration { get; set; }
        static string contentPath { get; set; }

        /// <summary>
        /// 构造函数初始化
        /// </summary>
        /// <param name="contentpath"></param>
        /// <param name="configuration"></param>
        public AppSettings(string contentpath)
        {
            var path = "appsettings.json";
            _configuration = new ConfigurationBuilder()
            .SetBasePath(contentPath)
            .Add(new JsonConfigurationSource { Path = path, Optional = false, ReloadOnChange = true })//这样的话，可以直接读目录里的json文件，而不是 bin 文件夹下的，所以不用修改复制属性
            .Build();

   

        }

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 对要操作的字符做封装处理
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static string app(params string[] sections)
        {

            try
            {
                if (sections.Any())
                {
                    var xx= _configuration[string.Join(":", sections)];
                    return xx;
                }
                return "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取配置信息数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static List<T> app<T>(params string[] sections)
        {

            try
            {
                List<T> list = new List<T>();
                _configuration.Bind(string.Join(":", sections), list);

                return list;

            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
