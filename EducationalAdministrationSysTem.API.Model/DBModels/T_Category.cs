using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_Category
    /// </summary>
    [SugarTable("T_Category","ChinaSouthernAirDB")]
     public class T_Category
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
        public int Id { get; set; }
        /// <summary>
        /// imgUrl
        /// </summary>
        public string imgUrl { get; set; }
        /// <summary>
        /// thumbImg
        /// </summary>
        public string thumbImg { get; set; }
        /// <summary>
        /// rank
        /// </summary>
        public string rank { get; set; }
        /// <summary>
        /// categoryName
        /// </summary>
        public string categoryName { get; set; }
        /// <summary>
        /// categoryId
        /// </summary>
        public string categoryId { get; set; }
        /// <summary>
        /// parentId
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// CategoryLevel
        /// </summary>
        public string CategoryLevel { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
