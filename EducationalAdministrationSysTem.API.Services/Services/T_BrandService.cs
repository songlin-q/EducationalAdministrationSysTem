using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_Brand服务接口
    /// </summary>
     public partial class T_BrandService :BaseServices<T_Brand>,IT_BrandService
    {
         private readonly IBaseRepository<T_Brand> _dal;
         public T_BrandService(IBaseRepository<T_Brand> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
