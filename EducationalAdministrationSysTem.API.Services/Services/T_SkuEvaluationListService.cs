using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_SkuEvaluationList服务接口
    /// </summary>
     public partial class T_SkuEvaluationListService :BaseServices<T_SkuEvaluationList>,IT_SkuEvaluationListService
    {
         private readonly IBaseRepository<T_SkuEvaluationList> _dal;
         public T_SkuEvaluationListService(IBaseRepository<T_SkuEvaluationList> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
