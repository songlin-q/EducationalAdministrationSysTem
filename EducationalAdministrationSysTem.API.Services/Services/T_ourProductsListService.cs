using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_ourProductsList服务接口
    /// </summary>
     public partial class T_ourProductsListService :BaseServices<T_ourProductsList>,IT_ourProductsListService
    {
         private readonly IBaseRepository<T_ourProductsList> _dal;
         public T_ourProductsListService(IBaseRepository<T_ourProductsList> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
