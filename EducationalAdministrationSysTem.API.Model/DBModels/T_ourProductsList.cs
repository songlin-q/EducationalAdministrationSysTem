using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_ourProductsList
    /// </summary>
    [SugarTable("T_ourProductsList","ChinaSouthernAirDB")]
     public class T_ourProductsList
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// ItemId
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// itemStatusString
        /// </summary>
        public string itemStatusString { get; set; }
        /// <summary>
        /// itemStatus
        /// </summary>
        public int itemStatus { get; set; }
        /// <summary>
        /// itemInventory
        /// </summary>
        public int itemInventory { get; set; }
        /// <summary>
        /// cid
        /// </summary>
        public int cid { get; set; }
        /// <summary>
        /// catName
        /// </summary>
        public string catName { get; set; }
        /// <summary>
        /// sellerSellPrice
        /// </summary>
        public decimal sellerSellPrice { get; set; }
        /// <summary>
        /// salecount
        /// </summary>
        public int salecount { get; set; }
        /// <summary>
        /// brandName
        /// </summary>
        public string brandName { get; set; }
    }
}
