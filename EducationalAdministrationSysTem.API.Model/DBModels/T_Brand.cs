using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_Brand
    /// </summary>
    [SugarTable("T_Brand","ChinaSouthernAirDB")]
     public class T_Brand
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// brandLogoUrl
        /// </summary>
        public string brandLogoUrl { get; set; }
        /// <summary>
        /// brandName
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// brandKey
        /// </summary>
        public string brandKey { get; set; }
        /// <summary>
        /// secondLevCid
        /// </summary>
        public int secondLevCid { get; set; }
        /// <summary>
        /// created
        /// </summary>
        public long created { get; set; }
        /// <summary>
        /// brandId
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// modified
        /// </summary>
        public long modified { get; set; }
        /// <summary>
        /// brandStatus
        /// </summary>
        public int brandStatus { get; set; }
        /// <summary>
        /// thirdLevCid
        /// </summary>
        public int thirdLevCid { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
