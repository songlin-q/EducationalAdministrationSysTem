using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.ViewModel;
using EducationalAdministrationSysTem.API.Services.Services;
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
        public IActionResult GetTokenInfo()
        {

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
