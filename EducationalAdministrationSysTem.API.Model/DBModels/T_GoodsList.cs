using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_GoodsList
    /// </summary>
    [SugarTable("T_GoodsList","ChinaSouthernAirDB")]
     public class T_GoodsList
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// ItemId
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// GoodsId
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// SkuName
        /// </summary>
        public string SkuName { get; set; }
        /// <summary>
        /// ImgUrl
        /// </summary>
        public string ImgUrl { get; set; }
        /// <summary>
        /// PinPaiName
        /// </summary>
        public string PinPaiName { get; set; }
        /// <summary>
        /// BrandId
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// TypeName
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// DuiHuanJiaGe
        /// </summary>
        public decimal? DuiHuanJiaGe { get; set; }
        /// <summary>
        /// DuiHuanJiFen
        /// </summary>
        public decimal? DuiHuanJiFen { get; set; }
        /// <summary>
        /// DuiHuanJiaGeMax
        /// </summary>
        public int? DuiHuanJiaGeMax { get; set; }
        /// <summary>
        /// salesVolume
        /// </summary>
        public int? salesVolume { get; set; }
        /// <summary>
        /// salesVolumestr
        /// </summary>
        public string salesVolumestr { get; set; }
        /// <summary>
        /// 会员里程价格
        /// </summary>
        public decimal? mileageDiscountPrice { get; set; }
        /// <summary>
        /// 会员类型
        /// </summary>
        public string ? memberTypeList { get; set; }
        /// <summary>
        /// 现金折扣价
        /// </summary>
        public decimal? cashDiscountPrice { get; set; }
        /// <summary>
        /// 支付单位
        /// </summary>
        public string ? payUnitStr { get; set; }
        /// <summary>
        /// DuiHuanJiaGeMin
        /// </summary>
        public int? DuiHuanJiaGeMin { get; set; }
        /// <summary>
        /// StoreName
        /// </summary>
        public string StoreName { get; set; }
        /// <summary>
        /// StoreId
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// ShouCangShu
        /// </summary>
        public int? ShouCangShu { get; set; }
        /// <summary>
        /// TypeId
        /// </summary>
        public int? TypeId { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// creatTime
        /// </summary>
        public DateTime? creatTime { get; set; }
        /// <summary>
        /// IsGetDetail
        /// </summary>
        public bool IsGetDetail { get; set; }
        /// <summary>
        /// GoodsPrice
        /// </summary>
        public decimal? GoodsPrice { get; set; }
        /// <summary>
        /// IsShow
        /// </summary>
        public bool IsShow { get; set; }
        /// <summary>
        /// IsOnline
        /// </summary>
        public bool IsOnline { get; set; }
        /// <summary>
        /// operateDate
        /// </summary>
        public DateTime? operateDate { get; set; }
        /// <summary>
        /// ScanPici
        /// </summary>
        public string ScanPici { get; set; }
        /// <summary>
        /// LastUpdateTime
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int? inventory { get; set; }
    }
}
