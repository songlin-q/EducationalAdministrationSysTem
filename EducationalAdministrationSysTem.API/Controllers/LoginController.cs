using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.JWT;
using EducationalAdministrationSysTem.API.Model.ViewModel;
using EducationalAdministrationSysTem.API.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationalAdministrationSysTem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
       
        private IT_StudentsService _t_StudentsService;

        public LoginController(IT_StudentsService t_StudentsService)
        {
            _t_StudentsService = t_StudentsService;
          
        }
          
        [HttpGet]
        public async Task<MessageModel> GetInfo()
        {
            MessageModel messageModel = new MessageModel();

            var counts = await _t_StudentsService.GetCountBy(s => true);
            messageModel.response = counts;
            return messageModel;


        }

        /// <summary>
        /// 获取token字符串
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetTokenInfo()
        {
            var uInfo = new View_AdminInfo() { 
            UserId=1,
            LoginName="Admin",
            RealName="Admin"
           
            };
            var xx = GetJwtToken.GenerateJwtToken(uInfo); ;

            return xx;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userJson">前端返回的用户信息json列表</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RegeditUserInfo(string userJson)
        {
            //解析字符串生成为model
             
            return null;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string value()
        {
            return "成功";
        }


    }
}
