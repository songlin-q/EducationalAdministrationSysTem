using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_GoodsList服务接口
    /// </summary>
     public partial class T_GoodsListService :BaseServices<T_GoodsList>,IT_GoodsListService
    {
         private readonly IBaseRepository<T_GoodsList> _dal;
         public T_GoodsListService(IBaseRepository<T_GoodsList> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
