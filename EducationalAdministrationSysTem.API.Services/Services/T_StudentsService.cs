using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_Students服务接口
    /// </summary>
     public partial class T_StudentsService :BaseServices<T_Students>,IT_StudentsService
    {
         private readonly IBaseRepository<T_Students> _dal;
         public T_StudentsService(IBaseRepository<T_Students> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
