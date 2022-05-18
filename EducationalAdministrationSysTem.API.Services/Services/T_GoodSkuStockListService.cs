using System;
using SqlSugar;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.IServices;
using EducationalAdministrationSysTem.API.Model.DBModels;
namespace EducationalAdministrationSysTem.API.Services.Services
{
    /// <summary>
    /// T_GoodSkuStockList服务接口
    /// </summary>
     public partial class T_GoodSkuStockListService :BaseServices<T_GoodSkuStockList>,IT_GoodSkuStockListService
    {
         private readonly IBaseRepository<T_GoodSkuStockList> _dal;
         public T_GoodSkuStockListService(IBaseRepository<T_GoodSkuStockList> dal)
         {
             this._dal = dal;
             base.baseDal = dal;
         }
    }
}
