using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Model.Model
{
    public class UserInfo
    {
        [SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int Id { get; set; }
        public string ?  UserName { get; set; }
        public int Age { get; set; }
        public string ? Class { get; set; }
    }
}
