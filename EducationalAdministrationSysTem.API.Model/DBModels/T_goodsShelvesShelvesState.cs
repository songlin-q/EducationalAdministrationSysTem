using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_goodsShelvesShelvesState
    /// </summary>
    [SugarTable("T_goodsShelvesShelvesState","ChinaSouthernAirDB")]
     public class T_goodsShelvesShelvesState
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// skuId
        /// </summary>
        public string skuId { get; set; }
        /// <summary>
        /// GoodId
        /// </summary>
        public string GoodId { get; set; }
        /// <summary>
        /// GoodName
        /// </summary>
        public string GoodName { get; set; }
        /// <summary>
        /// 销售数量(规格)
        /// </summary>
        public string GuiGe { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string catName { get; set; }
        /// <summary>
        /// 商品现金
        /// </summary>
        public decimal SkuAmount { get; set; }
        /// <summary>
        /// 商品里程
        /// </summary>
        public decimal Skukm { get; set; }
        /// <summary>
        /// 商品状态:4在售，8下架
        /// </summary>
        public int Goodstate { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? opreaDtae { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int Inventory { get; set; }
    }
}
