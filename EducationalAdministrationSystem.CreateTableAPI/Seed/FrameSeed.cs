using EducationalAdministrationSystem.API.Common.ConvertHelper;
using EducationalAdministrationSystem.API.Common.DB;
using SqlSugar;
using System.Text;
using static EducationalAdministrationSystem.CreateTableAPI.Seed.Models.CodeAndDbType;

namespace EducationalAdministrationSystem.CreateTableAPI.Seed
{
    public class FrameSeed
    {
        private static List<CodeType> GetCodeTypeList()
        {

            var list = new List<CodeType>
                {
                    new CodeType{  Name="int",
                                  CSharepType=CSharpDataType.@int.ToString(),
                                  DbType=new  DbTypeInfo[]{
                                                            new DbTypeInfo() { Name="int" },
                                                            new DbTypeInfo() { Name="int4" },
                                                            new DbTypeInfo() { Name="number", Length=9, DecimalDigits=0 },
                                                            new DbTypeInfo(){ Name="integer" }
                                    }
                    },
                     new CodeType{  Name="double",
                                  CSharepType=CSharpDataType.@double.ToString(),
                                  DbType=new  DbTypeInfo[]{
                                                            new DbTypeInfo() { Name="double" },
                                                            new DbTypeInfo() { Name="float" }
                                    }
                    },
                    new CodeType{
                                  Name="string10",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=10}
                                }
                    },
                    new CodeType{
                                  Name="ignore",
                                  CSharepType="建表忽略该类型字段，生成实体中@Model.IsIgnore 值为 true ",
                                  DbType=new DbTypeInfo[]{

                                }
                    },
                    new CodeType{
                                  Name="string36",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=36}
                                }
                    },
                    new CodeType{
                                  Name="string100",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=100}
                                }
                    },
                    new CodeType{
                                  Name="string200",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=200}
                                }
                    },
                    new CodeType{
                                  Name="string500",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=500}
                                }
                    },
                    new CodeType{
                                  Name="string2000",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="varchar",Length=2000}
                                }
                    },
                    new CodeType{
                                  Name="nString10",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=10},
                                                           new DbTypeInfo(){  Name="varchar",Length=10}
                                }
                    },
                    new CodeType{
                                  Name="nString36",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=36},
                                                           new DbTypeInfo(){  Name="varchar",Length=36}
                                }
                    },
                    new CodeType{
                                  Name="nString100",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=100},
                                                           new DbTypeInfo(){  Name="varchar",Length=100}
                                }
                    },
                    new CodeType{
                                  Name="nString200",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=200},
                                                           new DbTypeInfo(){  Name="varchar",Length=200}
                                }
                    },
                    new CodeType{
                                  Name="nString500",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=500},
                                                           new DbTypeInfo(){  Name="varchar",Length=500}
                                }
                    },
                    new CodeType{
                                  Name="nString2000",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="nvarchar",Length=2000},
                                                           new DbTypeInfo(){  Name="varchar",Length=2000}
                                }
                    },
                    new CodeType{
                                  Name="maxString",
                                  CSharepType=CSharpDataType.@string.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="text"},
                                                           new DbTypeInfo(){  Name="clob"},
                                                           new DbTypeInfo(){ Name="ntext"},
                                                            new DbTypeInfo(){ Name="sysname"}
                                }
                    },
                    new CodeType{
                                  Name="bool",
                                  CSharepType=CSharpDataType.@bool.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="bit"},
                                                           new DbTypeInfo(){  Name="number", Length=1},
                                                           new DbTypeInfo(){  Name="boolean" }
                                }
                    },
                    new CodeType{
                                  Name="DateTime",
                                  CSharepType=CSharpDataType.DateTime.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="datetime"},
                                                           new DbTypeInfo{ Name="datetime2"},
                                                           new DbTypeInfo(){  Name="date"}

                                }
                    },
                    new CodeType{
                                 Name="timestamp",
                                 CSharepType="byte[]",
                                 DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="timestamp"},
                                                           new DbTypeInfo{ Name="varbinary"},
                                                           new DbTypeInfo{Name="image"}

                                }
                    },
                    new CodeType{
                                  Name="decimal_18_8",
                                  CSharepType=CSharpDataType.@decimal.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="decimal",Length=18, DecimalDigits=8},
                                                           new DbTypeInfo(){  Name="number",Length=18, DecimalDigits=8},
                                                           new DbTypeInfo(){  Name="numeric",Length=18, DecimalDigits=8}
                                }
                    },
                    new CodeType{
                                  Name="decimal_18_4",
                                  CSharepType=CSharpDataType.@decimal.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="decimal",Length=18, DecimalDigits=4},
                                                           new DbTypeInfo(){  Name="number",Length=18, DecimalDigits=4},
                                                           new DbTypeInfo(){  Name="money",Length=0, DecimalDigits=0}
                                }
                    },
                    new CodeType{
                                  Name="decimal_18_2",
                                  CSharepType=CSharpDataType.@decimal.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="decimal",Length=18, DecimalDigits=2},
                                                           new DbTypeInfo(){  Name="number",Length=18, DecimalDigits=2}
                                }
                    },
                    new CodeType{
                                  Name="guid",
                                  CSharepType=CSharpDataType.Guid.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="uniqueidentifier"},
                                                           new DbTypeInfo(){  Name="guid"},
                                                           new DbTypeInfo(){  Name="char",Length=36}
                                }
                    },
                    new CodeType{
                                  Name="byte",
                                  CSharepType=CSharpDataType.@byte.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="tinyint"},
                                                           new DbTypeInfo(){  Name="varbit"},
                                                           new DbTypeInfo(){  Name="number",Length=3}
                                }
                    },
                    new CodeType{
                                  Name="short",
                                  CSharepType=CSharpDataType.@short.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="short"},
                                                           new DbTypeInfo(){  Name="int2"},
                                                           new DbTypeInfo(){  Name="int16"},
                                                           new DbTypeInfo(){  Name="smallint"},
                                                           new DbTypeInfo(){  Name="number",Length=5}

                                }
                    },
                    new CodeType{
                                  Name="long",
                                  CSharepType=CSharpDataType.@long.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="long"},
                                                           new DbTypeInfo(){  Name="int8"},
                                                           new DbTypeInfo(){  Name="int64"},
                                                           new DbTypeInfo(){  Name="bigint"},
                                                           new DbTypeInfo(){  Name="number",Length=19}

                                }
                    },
                    new CodeType{
                                  Name="byteArray",
                                  CSharepType="byte[]",
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="blob"},
                                                           new DbTypeInfo(){  Name="longblob"},
                                                           new DbTypeInfo(){  Name="binary"}

                                }
                    },
                    new CodeType{
                                  Name="datetimeoffset",
                                  CSharepType=CSharpDataType.DateTimeOffset.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="datetimeoffset"}

                                }
                    },
                    new CodeType{
                                  Name="json_default",
                                  CSharepType=CSharpDataType.DateTimeOffset.ToString(),
                                  DbType=new DbTypeInfo[]{
                                                           new DbTypeInfo(){  Name="json"},
                                                           new DbTypeInfo(){  Name="varchar", Length=3999}


                                }
                    }


                };
            foreach (var item in list)
            {
                item.Sort = 1000;
            }

            list.Add(new CodeType()
            {
                CSharepType = "DateTimeOffset",
                Name = "DateTimeOffset",
                DbType = new DbTypeInfo[]
                      {
                        new DbTypeInfo(){ Name="DateTimeOffset" },
                        new DbTypeInfo(){ Name="DateTime" }
                      }
            });
            list.Add(new CodeType()
            {
                CSharepType = "string",
                Name = "string_char10",
                Sort = 10000,
                DbType = new DbTypeInfo[]
                       {
                        new DbTypeInfo(){ Name="char",Length=10  }
                       }
            });
            return list;

        }

        /// <summary>
        /// 生成Model层
        /// </summary>
        /// <param name="sqlSugarScope">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <param name="isMuti"></param>
        /// <returns></returns>
        public static bool CreateModels(string path, SqlSugarScope sqlSugarScope, string ConnId, bool isMuti = false, string[] tableNames = null)
        {
            Create_Model_ClassFileByDBTalbe(sqlSugarScope, ConnId, path, "EducationalAdministrationSysTem.API", tableNames, "", isMuti);
            return true;
        }





        /// <summary>
        /// 生成 IService 层
        /// </summary>
        /// <param name="sqlSugarScope">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateIServices(string path, SqlSugarScope sqlSugarScope, string ConnId, bool isMuti = false, string[] tableNames = null)
        {
            Create_IServices_ClassFileByDBTalbe(sqlSugarScope, ConnId, path, "EducationalAdministrationSysTem.API", tableNames, "", isMuti);
            return true;
        }






        /// <summary>
        /// 生成 Service 层
        /// </summary>
        /// <param name="sqlSugarScope">sqlsugar实例</param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="isMuti"></param>
        /// <param name="tableNames">数据库表名数组，默认空，生成所有表</param>
        /// <returns></returns>
        public static bool CreateServices(string path, SqlSugarScope sqlSugarScope, string ConnId, bool isMuti = false, string[] tableNames = null)
        {
            Create_Services_ClassFileByDBTalbe(sqlSugarScope, ConnId, path, "EducationalAdministrationSysTem.API", tableNames, "", isMuti);
            return true;
        }


        #region 根据数据库表生产Model层

        /// <summary>
        /// 功能描述:根据数据库表生产Model层
        /// 作　　者:Blog.Core
        /// </summary>
        /// <param name="sqlSugarScope"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        /// <param name="blnSerializable">是否序列化</param>
        private static void Create_Model_ClassFileByDBTalbe(
          SqlSugarScope sqlSugarScope,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false,
          bool blnSerializable = false)
        {
            string houZhui = "";
            strPath += strNameSpace + @".Model\DBModels";

            //多库文件分离
            if (isMuti && MainDB.CurrentDbConnId.ToLower() != ConnId.ToLower())
            {

                houZhui = "." + ConnId;

                strPath = strPath + "\\" + ConnId;
                //strNameSpace = strNameSpace + "." + ConnId;
            }

            string sqllll = "SELECT obj.name TableName,f.value TableRemark FROM sysobjects obj  LEFT JOIN  sys.extended_properties f on  obj.id=f.major_id and f.minor_id=0 AND f.name='MS_Description' WHERE obj.type IN('U','V')";

            var dt00 = sqlSugarScope.Ado.GetDataTable(sqllll);


            var tableRemarkList = ModelConvertHelper<TableInfo>.ConvertToModel(dt00, false).ToList();


            string dbName = sqlSugarScope.Ado.GetDataTable("Select Name From Master..SysDataBases Where DbId=(Select Dbid From Master..SysProcesses Where Spid = @@spid)").Rows[0][0].ToString();


            //f.value TableRemark,
            string sqlll = @"SELECT
obj.name TableName,

colm.column_id ColumnID,
CAST(CASE WHEN idxic.name IS NULL THEN 0 ELSE 1 END AS BIT) IsPrimaryKey,
colm.name ColumnName,								
colm.object_id TableId,									
systype.name ColumnType,
systype.system_type_id,
colm.is_identity IsIdentity,
colm.is_nullable IsNullable,
cast(colm.max_length as int) ByteLength,
                                    (
                                        case 
                                            when systype.name='nvarchar' and colm.max_length>0 then colm.max_length/2 
                                            when systype.name='nchar' and colm.max_length>0 then colm.max_length/2
                                            when systype.name='ntext' and colm.max_length>0 then colm.max_length/2 
                                            else colm.max_length
                                        end
                                    ) CharLength,
                                    cast(colm.precision as int) Precision,
                                    cast(colm.scale as int) Scale,
prop.value Remark
FROM sysobjects obj INNER JOIN  " + dbName + @".sys.columns colm ON colm.object_id = obj.id 
inner join " + dbName + @".sys.types systype ON systype.system_type_id = colm.system_type_id and colm.user_type_id=systype.user_type_id
LEFT JOIN 
(SELECT idx.name,idx.object_id,ic.column_id from " + dbName + @".sys.indexes idx INNER JOIN " + dbName + @".sys.index_columns ic ON ic.index_id = idx.index_id  AND ic.object_id = idx.object_id WHERE idx.is_primary_key=1) idxic ON  idxic.object_id = colm.object_id AND idxic.column_id = colm.column_id
 left join " + dbName + @".sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id

WHERE obj.type IN('U','V')";
            // LEFT JOIN  sys.extended_properties f on  obj.id=f.major_id and f.minor_id=0 AND f.name='MS_Description'

            var dt = sqlSugarScope.Ado.GetDataTable(sqlll);


            var nn = ModelConvertHelper<TableInfo>.ConvertToModel(dt, false).ToList();

            if (tableRemarkList != null)
            {
                nn.ForEach(aa =>
                {

                    aa.TableRemark = tableRemarkList.Where(tt => tt.TableName == aa.TableName).Select(tt => tt.TableRemark).FirstOrDefault();

                });
            }

            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                var ddd = lstTableNames.ToList();
                nn = nn.Where(aa => ddd.Contains(aa.TableName)).ToList();
            }

            // var mm=  IDbFirst.IsCreateDefaultValue().IsCreateAttribute().W).ToClassStringList();
            var lls = new Dictionary<string, string>();
            var tbList = nn.GroupBy(aa => aa.TableName).ToList();
            tbList.ForEach(a =>
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("using System;");
                sb.AppendLine("using SqlSugar;");
                sb.AppendLine("namespace " + strNameSpace + ".Model.DBModels" + houZhui);
                sb.AppendLine("{");

                sb.AppendLine("    /// <summary>");
                sb.AppendLine("    /// " + (string.IsNullOrWhiteSpace(a.FirstOrDefault().TableRemark) ? a.Key : a.FirstOrDefault().TableRemark));
                sb.AppendLine("    /// </summary>");

                sb.AppendLine("    [SugarTable(\"" + a.Key + "\",\"" + ConnId + "\")]");
                sb.AppendLine("     public class " + a.Key);


                sb.AppendLine("    {");
                a.ToList().ForEach(column =>
                {

                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// " + (string.IsNullOrWhiteSpace(column.Remark) ? column.ColumnName : column.Remark.Replace("\r\n", " ")));
                    sb.AppendLine("        /// </summary>");
                    if (column.IsPrimaryKey && column.IsIdentity)
                    {
                        sb.AppendLine("        [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]");
                    }

                    var listtypes = GetCodeTypeList();
                    var csharpType = listtypes.FirstOrDefault(it => it.CSharepType.Equals(column.ColumnType, StringComparison.OrdinalIgnoreCase) || it.DbType.Any(y => y.Name.Equals(column.ColumnType, StringComparison.OrdinalIgnoreCase)))?.CSharepType;


                    string isNullableStr = "";

                    if (column.ColumnType.ToLower() == "int32")
                    {
                        csharpType = listtypes.Where(it => it.CSharepType == "int").First().CSharepType;
                    }
                    if (column.ColumnType.ToLower() == "int16")
                    {
                        csharpType = listtypes.Where(it => it.CSharepType == "short").First().CSharepType;
                    }
                    if (column.ColumnType.ToLower() == "int64")
                    {
                        csharpType = listtypes.Where(it => it.CSharepType == "long").First().CSharepType;
                    }
                    if (string.IsNullOrEmpty(column.ColumnType))
                    {
                        csharpType = listtypes.Where(it => it.CSharepType == "string").First().CSharepType;
                    }

                    if (csharpType != "string")
                    {
                        if (column.IsNullable)
                        {
                            isNullableStr = "?";
                        }
                    }

                    sb.AppendLine("        public " + csharpType + isNullableStr + " " + column.ColumnName + " { get; set; }");

                });

                sb.AppendLine("    }");
                sb.AppendLine("}");

                lls.Add(a.Key, sb.ToString());
            });
            CreateFilesByClassStringList(lls, strPath, "{0}");
        }
        #endregion



        #region 根据数据库表生产IServices层

        /// <summary>
        /// 功能描述:根据数据库表生产IServices层
        /// 作　　者:Blog.Core
        /// </summary>
        /// <param name="sqlSugarScope"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_IServices_ClassFileByDBTalbe(
          SqlSugarScope sqlSugarScope,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {

            string houZhui = "";
            strPath += strNameSpace + @".IServices\IServices";

            //多库文件分离
            if (isMuti && MainDB.CurrentDbConnId.ToLower() != ConnId.ToLower())
            {

                houZhui = "." + ConnId;

                strPath = strPath + "\\" + ConnId;
                //strNameSpace = strNameSpace + "." + ConnId;
            }





            string sqllll = "SELECT obj.name TableName,f.value TableRemark FROM sysobjects obj  LEFT JOIN  sys.extended_properties f on  obj.id=f.major_id and f.minor_id=0 AND f.name='MS_Description' WHERE obj.type IN('U','V')";
            var dt = sqlSugarScope.Ado.GetDataTable(sqllll);
            var nn = ModelConvertHelper<TableInfo>.ConvertToModel(dt, false).ToList();
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                var ddd = lstTableNames.ToList();
                nn = nn.Where(aa => ddd.Contains(aa.TableName)).ToList();
            }

            var lls = new Dictionary<string, string>();
            var tbList = nn.GroupBy(aa => aa.TableName).ToList();
            tbList.ForEach(a =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("using System;");
                sb.AppendLine("using SqlSugar;");
                sb.AppendLine("using " + strNameSpace + ".IServices.Base;");
                sb.AppendLine("using " + strNameSpace + ".Model.DBModels" + houZhui + ";");
                sb.AppendLine("namespace " + strNameSpace + ".IServices.IServices" + houZhui);
                sb.AppendLine("{");

                sb.AppendLine("    /// <summary>");
                sb.AppendLine("    /// " + (string.IsNullOrWhiteSpace(a.FirstOrDefault().TableRemark) ? a.Key : a.FirstOrDefault().TableRemark) + "服务接口");
                sb.AppendLine("    /// </summary>");
                sb.AppendLine("     public partial interface I" + a.Key + "Service :IBaseServices<" + a.Key + ">" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)));
                sb.AppendLine("    {");

                sb.AppendLine("    }");
                sb.AppendLine("}");


                lls.Add(a.Key, sb.ToString());
            });

            CreateFilesByClassStringList(lls, strPath, "I{0}Service");
        }
        #endregion





        #region 根据数据库表生产 Services 层

        /// <summary>
        /// 功能描述:根据数据库表生产 Services 层
        /// 作　　者:Blog.Core
        /// </summary>
        /// <param name="sqlSugarScope"></param>
        /// <param name="ConnId">数据库链接ID</param>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isMuti"></param>
        private static void Create_Services_ClassFileByDBTalbe(
          SqlSugarScope sqlSugarScope,
          string ConnId,
          string strPath,
          string strNameSpace,
          string[] lstTableNames,
          string strInterface,
          bool isMuti = false)
        {


            string houZhui = "";
            strPath += strNameSpace + @".Services\Services";

            //多库文件分离
            if (isMuti && MainDB.CurrentDbConnId.ToLower() != ConnId.ToLower())
            {

                houZhui = "." + ConnId;

                strPath = strPath + "\\" + ConnId;
                //strNameSpace = strNameSpace + "." + ConnId;
            }
            string sqllll = "SELECT obj.name TableName,f.value TableRemark FROM sysobjects obj  LEFT JOIN  sys.extended_properties f on  obj.id=f.major_id and f.minor_id=0 AND f.name='MS_Description' WHERE obj.type IN('U','V')";
            var dt = sqlSugarScope.Ado.GetDataTable(sqllll);
            var nn = ModelConvertHelper<TableInfo>.ConvertToModel(dt, false).ToList();
            if (lstTableNames != null && lstTableNames.Length > 0)
            {
                var ddd = lstTableNames.ToList();
                nn = nn.Where(aa => ddd.Contains(aa.TableName)).ToList();
            }

            var lls = new Dictionary<string, string>();
            var tbList = nn.GroupBy(aa => aa.TableName).ToList();
            tbList.ForEach(a =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("using System;");
                sb.AppendLine("using SqlSugar;");
                sb.AppendLine("using " + strNameSpace + ".Services.Base;");
                sb.AppendLine("using " + strNameSpace + ".IRepository.Base;");
                sb.AppendLine("using " + strNameSpace + ".IServices.IServices" + houZhui + ";");
                sb.AppendLine("using " + strNameSpace + ".Model.DBModels" + houZhui + ";");
                sb.AppendLine("namespace " + strNameSpace + ".Services.Services" + houZhui);
                sb.AppendLine("{");

                sb.AppendLine("    /// <summary>");
                sb.AppendLine("    /// " + (string.IsNullOrWhiteSpace(a.FirstOrDefault().TableRemark) ? a.Key : a.FirstOrDefault().TableRemark) + "服务接口");
                sb.AppendLine("    /// </summary>");
                sb.AppendLine("     public partial class " + a.Key + "Service :BaseServices<" + a.Key + ">,I" + a.Key + "Service" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)));
                sb.AppendLine("    {");



                sb.AppendLine("         private readonly IBaseRepository<" + a.Key + "> _dal;");
                sb.AppendLine("         public " + a.Key + "Service(IBaseRepository<" + a.Key + "> dal)");
                sb.AppendLine("         {");
                sb.AppendLine("             this._dal = dal;");
                sb.AppendLine("             base.baseDal = dal;");
                sb.AppendLine("         }");

                sb.AppendLine("    }");
                sb.AppendLine("}");


                lls.Add(a.Key, sb.ToString());
            });
            //            var IDbFirst = sqlSugarScope.DbFirst;
            //            if (lstTableNames != null && lstTableNames.Length > 0)
            //            {
            //                IDbFirst = IDbFirst.Where(lstTableNames);
            //            }
            //            var ls = IDbFirst.IsCreateDefaultValue().IsCreateAttribute()

            //                  .SettingClassTemplate(p => p =
            //@"
            //using Blog.Core.IServices" + (isMuti ? "." + ConnId + "" : "") + @";
            //using Blog.Core.Model.Models" + (isMuti ? "." + ConnId + "" : "") + @";
            //using Blog.Core.Services.BASE;
            //using Blog.Core.IRepository.Base;

            //namespace " + strNameSpace + @"
            //{
            //    public class {ClassName}Services : BaseServices<{ClassName}>, I{ClassName}Services" + (string.IsNullOrEmpty(strInterface) ? "" : (" , " + strInterface)) + @"
            //    {
            //        private readonly IBaseRepository<{ClassName}> _dal;
            //        public {ClassName}Services(IBaseRepository<{ClassName}> dal)
            //        {
            //            this._dal = dal;
            //            base.BaseDal = dal;
            //        }
            //    }
            //}")
            //                  .ToClassStringList(strNameSpace);

            CreateFilesByClassStringList(lls, strPath, "{0}Service");
        }
        #endregion


        #region 根据模板内容批量生成文件
        /// <summary>
        /// 根据模板内容批量生成文件
        /// </summary>
        /// <param name="ls">类文件字符串list</param>
        /// <param name="strPath">生成路径</param>
        /// <param name="fileNameTp">文件名格式模板</param>
        private static void CreateFilesByClassStringList(Dictionary<string, string> ls, string strPath, string fileNameTp)
        {

            foreach (var item in ls)
            {
                var fileName = $"{string.Format(fileNameTp, item.Key)}.cs";
                var fileFullPath = Path.Combine(strPath, fileName);
                if (!Directory.Exists(strPath))
                {
                    Directory.CreateDirectory(strPath);
                }
                File.WriteAllText(fileFullPath, item.Value, Encoding.UTF8);
            }
        }
        #endregion


        public class TableInfo
        {
            public string TableName { get; set; }
            public int ColumnID { get; set; }
            public bool IsPrimaryKey { get; set; }
            public string ColumnName { get; set; }
            public int TableId { get; set; }
            public string ColumnType { get; set; }
            public int system_type_id { get; set; }
            public bool IsIdentity { get; set; }
            public bool IsNullable { get; set; }
            public int ByteLength { get; set; }
            public int CharLength { get; set; }
            public int Precision { get; set; }
            public int Scale { get; set; }
            public string Remark { get; set; }
            public string TableRemark { get; set; }

        }
    }
}
