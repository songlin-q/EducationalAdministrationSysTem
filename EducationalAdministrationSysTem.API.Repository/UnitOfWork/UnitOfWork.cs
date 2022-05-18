using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlSugarScope _sqlSugarScope;
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(SqlSugarScope sqlSugarClient, ILogger<UnitOfWork> logger)
        {
            _sqlSugarScope = sqlSugarClient;
            _logger = logger;
        }
        /// <summary>
        /// 获取DB，保证唯一性
        /// </summary>
        /// <returns></returns>
        public SqlSugarScope GetDbClient()
        {
            // 必须要as，后边会用到切换数据库操作
            return _sqlSugarScope;
        }
        public void BeginTran()
        {
            GetDbClient().BeginTran();
        }

        public void CommitTran()
        {
            try
            {
                GetDbClient().CommitTran(); //
            }
            catch (Exception ex)
            {
                GetDbClient().RollbackTran();
                _logger.LogError($"{ex.Message}\r\n{ex.InnerException}");
            }
        }

        public void RollbackTran()
        {
            GetDbClient().RollbackTran();
        }
    }
}
