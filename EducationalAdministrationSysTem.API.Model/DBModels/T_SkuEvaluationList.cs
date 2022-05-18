using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_SkuEvaluationList
    /// </summary>
    [SugarTable("T_SkuEvaluationList","ChinaSouthernAirDB")]
     public class T_SkuEvaluationList
    {
        /// <summary>
        /// mainId
        /// </summary>
        public int mainId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
        /// <summary>
        /// 客户手机号
        /// </summary>
        public string relTel { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string contact { get; set; }
        /// <summary>
        /// ItemId
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// 评价商品
        /// </summary>
        public string skuName { get; set; }
        /// <summary>
        /// 追加内容
        /// </summary>
        public string addContent { get; set; }
        /// <summary>
        /// 评价级别
        /// </summary>
        public string evaluationLevel { get; set; }
        /// <summary>
        /// 初次评价时间
        /// </summary>
        public DateTime firtstEvaluationTime { get; set; }
        /// <summary>
        /// 是否回复
        /// </summary>
        public bool Isrep { get; set; }
        /// <summary>
        /// 审核状态:1:审核中，2:审核通过，3:审核不通过
        /// </summary>
        public int Auditostr { get; set; }
    }
}
