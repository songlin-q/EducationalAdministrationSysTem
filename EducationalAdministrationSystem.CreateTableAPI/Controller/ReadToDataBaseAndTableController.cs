using EducationalAdministrationSystem.API.Common.DB;
using EducationalAdministrationSystem.API.Common.Helper;
using EducationalAdministrationSystem.CreateTableAPI.Seed;
using EducationalAdministrationSysTem.API.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EducationalAdministrationSystem.CreateTableAPI.Controller
{
    /// <summary>
    /// 读写数据库的方法
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReadToDataBaseAndTableController : ControllerBase
    {
        private readonly SqlSugarScope _sqlSugarScope;//sqlsugar的事务
        private readonly IWebHostEnvironment Env;

        /// <summary>
        /// 构造函数进行依赖注入
        /// </summary>
        public ReadToDataBaseAndTableController(SqlSugarScope sqlSugarScope, IWebHostEnvironment webHostEnvironment)
        {
            _sqlSugarScope = sqlSugarScope;
            Env = webHostEnvironment;
        }

        /// <summary>
        /// 获取整体的框架  文件(主库)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MessageModel<string> GetCompleteFile()
        {
            var path = Env.ContentRootPath;

            var singlePath = Directory.GetParent(path).Parent.FullName + "\\";
            var path2 = Directory.GetParent(path);
            var path3 = path2.Parent;
            var data = new MessageModel<string>() { success = true, msg = "" };
            if (path == path2.FullName)
            {

            }


            var isMuti = AppSettings.app(new string[] { "MutiDBEnabled" }).ObjToBool();


            data.response += @"file path is:C:\my-file\}";

            if (Env.IsDevelopment())
            {
                BaseDBConfig.MutiConnectionString.allDbs.ToList().ForEach(item =>
                {
                    _sqlSugarScope.ChangeDatabase(item.ConnId.ToLower());
                    data.response += $"库{item.ConnId}-Model层生成：{FrameSeed.CreateModels(singlePath, _sqlSugarScope, item.ConnId, isMuti)} || ";

                    data.response += $"库{item.ConnId}-IServices层生成：{FrameSeed.CreateIServices(singlePath, _sqlSugarScope, item.ConnId, isMuti)} || ";
                    //data.response += $"库{m.ConnId}-Repository层生成：{FrameSeed.CreateRepository(_sqlSugarScope, m.ConnId, isMuti)} || ";
                    data.response += $"库{item.ConnId}-Services层生成：{FrameSeed.CreateServices(singlePath, _sqlSugarScope, item.ConnId, isMuti)} || ";
                });
                _sqlSugarScope.ChangeDatabase(MainDB.CurrentDbConnId.ToLower());

            }
            else
            {
                data.success = false;
                data.msg = "当前不处于开发模式，代码生成不可用！";
            }


            return data;
        }



    }
}
