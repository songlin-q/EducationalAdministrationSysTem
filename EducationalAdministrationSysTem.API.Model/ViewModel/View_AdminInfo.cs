using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Model.ViewModel
{
    public class View_AdminInfo
    {
        public string LoginName { get; set; }
        public string RealName { get; set; }
        public int ZuZhiId { get; set; }
        public int RoleId { get; set; }
        public string Tel { get; set; }
        public string GUID { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }

        public bool IsSuperAdmin { get; set; }

        public string avatarUrl { get; set; }

        public string nickName { get; set; }

        public bool IsJIngYong { get; set; }

        public List<int> MenuIds { get; set; }
    }
}
