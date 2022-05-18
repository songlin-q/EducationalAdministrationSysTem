using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_SkuSecondsKill服务接口
    /// </summary>
     public partial class T_SkuSecondsKillService :BaseServices<T_SkuSecondsKill>,IT_SkuSecondsKillService
    {
         private readonly IBaseRepository<T_SkuSecondsKill> _dal;
         public T_SkuSecondsKillService(IBaseRepository<T_SkuSecondsKill> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
