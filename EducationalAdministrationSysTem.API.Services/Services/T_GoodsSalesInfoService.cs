using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_GoodsSalesInfo服务接口
    /// </summary>
     public partial class T_GoodsSalesInfoService :BaseServices<T_GoodsSalesInfo>,IT_GoodsSalesInfoService
    {
         private readonly IBaseRepository<T_GoodsSalesInfo> _dal;
         public T_GoodsSalesInfoService(IBaseRepository<T_GoodsSalesInfo> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
