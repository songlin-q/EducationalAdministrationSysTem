using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_Category服务接口
    /// </summary>
     public partial class T_CategoryService :BaseServices<T_Category>,IT_CategoryService
    {
         private readonly IBaseRepository<T_Category> _dal;
         public T_CategoryService(IBaseRepository<T_Category> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
