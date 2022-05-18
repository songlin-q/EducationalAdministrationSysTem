using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_GoodSkuStockList
    /// </summary>
    [SugarTable("T_GoodSkuStockList","ChinaSouthernAirDB")]
     public class T_GoodSkuStockList
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// skuNo
        /// </summary>
        public string skuNo { get; set; }
        /// <summary>
        /// spuNo
        /// </summary>
        public string spuNo { get; set; }
        /// <summary>
        /// skuName
        /// </summary>
        public string skuName { get; set; }
        /// <summary>
        /// brandId
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string attrName { get; set; }
        /// <summary>
        /// brandName
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// cateid
        /// </summary>
        public int cateid { get; set; }
        /// <summary>
        /// categroyName
        /// </summary>
        public string categroyName { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal saleAmount { get; set; }
        /// <summary>
        /// 结算价
        /// </summary>
        public decimal selttementAmount { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public string skuStatus { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int stockCount { get; set; }
        /// <summary>
        /// IsSupp
        /// </summary>
        public bool IsSupp { get; set; }
        /// <summary>
        /// sysSkuName
        /// </summary>
        public string sysSkuName { get; set; }
        /// <summary>
        /// sysGoodskuId
        /// </summary>
        public int sysGoodskuId { get; set; }
        /// <summary>
        /// 比价链接
        /// </summary>
        public string comparisonLinks { get; set; }
        /// <summary>
        /// 对应关系ID
        /// </summary>
        public int duiYingGuanXiId { get; set; }
    }
}
