using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_goodsShelvesShelvesState服务接口
    /// </summary>
     public partial class T_goodsShelvesShelvesStateService :BaseServices<T_goodsShelvesShelvesState>,IT_goodsShelvesShelvesStateService
    {
         private readonly IBaseRepository<T_goodsShelvesShelvesState> _dal;
         public T_goodsShelvesShelvesStateService(IBaseRepository<T_goodsShelvesShelvesState> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
