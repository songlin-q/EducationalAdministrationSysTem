using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_Product
    /// </summary>
    [SugarTable("T_Product","ChinaSouthernAirDB")]
     public class T_Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// itemId
        /// </summary>
        public int itemId { get; set; }
        /// <summary>
        /// skuId
        /// </summary>
        public int skuId { get; set; }
        /// <summary>
        /// memberDiscountPriceDTOList
        /// </summary>
        public string memberDiscountPriceDTOList { get; set; }
        /// <summary>
        /// salesVolumeStr
        /// </summary>
        public string salesVolumeStr { get; set; }
        /// <summary>
        /// salesVolume
        /// </summary>
        public int salesVolume { get; set; }
        /// <summary>
        /// showWhichPrice
        /// </summary>
        public string showWhichPrice { get; set; }
        /// <summary>
        /// payUnitStr
        /// </summary>
        public string payUnitStr { get; set; }
        /// <summary>
        /// sortNumber
        /// </summary>
        public int sortNumber { get; set; }
        /// <summary>
        /// secKillFlag
        /// </summary>
        public int secKillFlag { get; set; }
        /// <summary>
        /// sellerMileageMarketPrice
        /// </summary>
        public string sellerMileageMarketPrice { get; set; }
        /// <summary>
        /// enableMaxMileageLimit
        /// </summary>
        public int enableMaxMileageLimit { get; set; }
        /// <summary>
        /// memberManualDiscountFlag
        /// </summary>
        public int memberManualDiscountFlag { get; set; }
        /// <summary>
        /// itemName
        /// </summary>
        public string itemName { get; set; }
        /// <summary>
        /// applauseRateStr
        /// </summary>
        public string applauseRateStr { get; set; }
        /// <summary>
        /// payType
        /// </summary>
        public int payType { get; set; }
        /// <summary>
        /// secKillRemainInventory
        /// </summary>
        public int secKillRemainInventory { get; set; }
        /// <summary>
        /// imageUrl
        /// </summary>
        public string imageUrl { get; set; }
        /// <summary>
        /// mileageSecKillPrice
        /// </summary>
        public string mileageSecKillPrice { get; set; }
        /// <summary>
        /// enableMileageRedemptionRatio
        /// </summary>
        public int enableMileageRedemptionRatio { get; set; }
        /// <summary>
        /// itemCashPrice
        /// </summary>
        public decimal itemCashPrice { get; set; }
        /// <summary>
        /// memberDiscountFlag
        /// </summary>
        public int memberDiscountFlag { get; set; }
        /// <summary>
        /// cashSecKillPrice
        /// </summary>
        public int cashSecKillPrice { get; set; }
        /// <summary>
        /// itemMileagePrice
        /// </summary>
        public string itemMileagePrice { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// thirdLevCid
        /// </summary>
        public int thirdLevCid { get; set; }
        /// <summary>
        /// BrandId
        /// </summary>
        public int BrandId { get; set; }
    }
}
