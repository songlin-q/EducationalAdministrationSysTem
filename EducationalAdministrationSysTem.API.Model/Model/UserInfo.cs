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
        public string username { get; set; }
        public string userEmail { get; set; }
        public string userTel { get; set; }
        public string userCode { get; set; }
        public string userPassword { get; set; }
    }
}
