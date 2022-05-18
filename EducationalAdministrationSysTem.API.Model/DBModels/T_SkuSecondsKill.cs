using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_SkuSecondsKill
    /// </summary>
    [SugarTable("T_SkuSecondsKill","ChinaSouthernAirDB")]
     public class T_SkuSecondsKill
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// 排期
        /// </summary>
        public int schedul { get; set; }
        /// <summary>
        /// 类目ID
        /// </summary>
        public int cid { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// 商品Id
        /// </summary>
        public int skuId { get; set; }
        /// <summary>
        /// skuName
        /// </summary>
        public string skuName { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        public decimal originalPrice { get; set; }
        /// <summary>
        /// 秒杀价
        /// </summary>
        public decimal secondsKill { get; set; }
        /// <summary>
        /// 折扣率
        /// </summary>
        public decimal discountRate { get; set; }
        /// <summary>
        /// 获取的最初数量
        /// </summary>
        public int oldCount { get; set; }
        /// <summary>
        /// 最新数量
        /// </summary>
        public int newCount { get; set; }
        /// <summary>
        /// 销售量
        /// </summary>
        public int salesCount { get; set; }
        /// <summary>
        /// 秒杀销量
        /// </summary>
        public int sencondSkuillCount { get; set; }
        /// <summary>
        /// 是否我司产品
        /// </summary>
        public bool ISOurCompany { get; set; }
        /// <summary>
        /// addTime
        /// </summary>
        public DateTime addTime { get; set; }
    }
}
