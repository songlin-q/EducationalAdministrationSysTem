using EducationalAdministrationSysTem.API.Model.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Model.Context
{
    public class SqlSugarContext
    {
        public readonly ISqlSugarClient db;
        public SqlSugarContext(ISqlSugarClient sqlSugarClient)
        {
            db=sqlSugarClient;
        }
        /// <summary>
        /// 将数据模型生成到数据库中
        /// </summary>
        public void CreateTable()
        {
            db.DbMaintenance.CreateDatabase();//没有数据库则创建
            db.CodeFirst.SetStringDefaultLength(50).BackupTable().InitTables(new Type[] {
                typeof(UserInfo)//根据userInfo创建表结构
            });
        }
        /// <summary>
        /// 将数据库的表生成为数据模型
        /// </summary>
        public void CreateModelToClass()
        {
            //获取到当前这个文件所在的路径

            db.DbFirst.IsCreateAttribute().CreateClassFile("D:\\Models\\", "Models");
        }

   

    }
}
