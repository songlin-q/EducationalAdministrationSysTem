using EducationalAdministrationSysTem.API.Model.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EducationalAdministrationSysTem.API.Controllers
{
    /// <summary>
    /// 用户接口
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class CreateTableController : ControllerBase
    {

        public readonly SqlSugarContext db;
        public CreateTableController(SqlSugarContext sqlSugarContext)
        { 
        this.db = sqlSugarContext;
        }
        /// <summary>
        /// 映射表到数据库
        /// </summary>
        /// 
        /// 
        /// <returns></returns>
        [HttpGet]
       
        public string CreateTables()
        {
            db.CreateTable();
            return "映射表成功!";
        }
        /// <summary>
        /// 将数据库中的表生成为数据模型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string CreateTablesFile()
        {
            db.CreateModelToClass();
            return "创建实体模型成功!";
        }
    }




}
