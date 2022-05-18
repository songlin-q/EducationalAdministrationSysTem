using EducationalAdministrationSystem.API.Common.DB;
using EducationalAdministrationSystem.API.Common.Helper;
using SqlSugar;


namespace EducationalAdministrationSystem.CreateTableAPI.Setup
{
    /// <summary>
    /// 
    /// </summary>
    public static class SqlSugarSetup
    {
        public static void AddSqlsugarSetup(this IServiceCollection services)
        {
            // 默认添加主数据库连接
            MainDB.CurrentDbConnId = AppSettings.app(new string[] { "MainDB" });
            // 把多个连接对象注入服务，这里必须采用Scope，因为有事务操作
            services.AddScoped<SqlSugarScope>(o =>
            {
                // 连接字符串
                var listConfig = new List<ConnectionConfig>();


                var dddd = BaseDBConfig.MutiConnectionString.allDbs;
                dddd.ForEach(m =>
                {
                    listConfig.Add(new ConnectionConfig()
                    {
                        ConfigId = m.ConnId.ObjToString().ToLower(),
                        ConnectionString = m.Connection,
                        DbType = (DbType)m.DbType,
                        IsAutoCloseConnection = true,

                        AopEvents = new AopEvents
                        {
                            OnLogExecuting = (sql, p) =>
                            {
                               
                            },
                        },
                        MoreSettings = new ConnMoreSettings()
                        {
                            //IsWithNoLockQuery = true,
                            IsAutoRemoveDataCache = true
                        },
                        // 从库
                        // SlaveConnectionConfigs = listConfig_Slave,
                        // 自定义特性
                        ConfigureExternalServices = new ConfigureExternalServices()
                        {
                            EntityService = (property, column) =>
                            {
                                if (column.IsPrimarykey && property.PropertyType == typeof(int))
                                {
                                    column.IsIdentity = true;
                                }
                            }
                        },
                        InitKeyType = InitKeyType.Attribute
                    }
                   );
                });
                return new SqlSugarScope(listConfig);
            });

        }
        private static string GetWholeSql(SugarParameter[] paramArr, string sql)
        {
            foreach (var param in paramArr)
            {
                sql.Replace(param.ParameterName, param.Value.ObjToString());
            }

            return sql;
        }

        private static string GetParas(SugarParameter[] pars)
        {
            string key = "【SQL参数】：";
            foreach (var param in pars)
            {
                key += $"{param.ParameterName}:{param.Value}\n";
            }

            return key;
        }
    }
}
