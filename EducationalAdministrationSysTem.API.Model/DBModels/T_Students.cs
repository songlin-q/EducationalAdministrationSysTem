using System;
using SqlSugar;
namespace EducationalAdministrationSysTem.API.Model.DBModels
{
    /// <summary>
    /// T_Students
    /// </summary>
    [SugarTable("T_Students","EducationSystem")]
     public class T_Students
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string student_No { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string student_Name { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int student_Age { get; set; }
        /// <summary>
        /// 学生家庭住址
        /// </summary>
        public string student_Address { get; set; }
    }
}
