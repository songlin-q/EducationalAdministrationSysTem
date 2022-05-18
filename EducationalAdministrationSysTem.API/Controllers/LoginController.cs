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
        private IT_BrandService _t_BrandService;

        public LoginController(IT_BrandService t_BrandService)
        {
            _t_BrandService = t_BrandService;
        }

        [HttpGet]
        public async Task<MessageModel> GetInfo()
        {
            MessageModel messageModel = new MessageModel();

            var counts = await _t_BrandService.GetCountBy(s => true);
            messageModel.response = counts;
            return messageModel;


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
