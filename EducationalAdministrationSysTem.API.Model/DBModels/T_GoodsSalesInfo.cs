using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_GoodsSalesInfo
    /// </summary>
    [SugarTable("T_GoodsSalesInfo","ChinaSouthernAirDB")]
     public class T_GoodsSalesInfo
    {
        /// <summary>
        /// goodsId
        /// </summary>
        public string goodsId { get; set; }
        /// <summary>
        /// salesCount
        /// </summary>
        public int salesCount { get; set; }
        /// <summary>
        /// addTime
        /// </summary>
        public string addTime { get; set; }
    }
}
