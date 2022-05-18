using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_Product服务接口
    /// </summary>
     public partial class T_ProductService :BaseServices<T_Product>,IT_ProductService
    {
         private readonly IBaseRepository<T_Product> _dal;
         public T_ProductService(IBaseRepository<T_Product> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
