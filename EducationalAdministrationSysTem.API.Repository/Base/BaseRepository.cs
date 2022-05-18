using EducationalAdministrationSystem.API.Common.DB;
using EducationalAdministrationSystem.API.Common.Helper;
using EducationalAdministrationSysTem.API.Repository.UnitOfWork;
using NPOI.SS.Formula.Functions;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Repository.Base
{

    /// <summary>
    /// 仓储层
    /// </summary>
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {


        private SqlSugarScope _dbBaseTmp;
        private readonly IUnitOfWork _unitOfWork;




        private SqlSugarScope _db
        {
            get
            {
                /* 如果要开启多库支持，
                 * 1、在appsettings.json 中开启MutiDBEnabled节点为true，必填
                 * 2、设置一个主连接的数据库ID，节点MainDB，对应的连接字符串的Enabled也必须true，必填
                 */
                if (AppSettings.app(new string[] { "MutiDBEnabled" }).ObjToBool())
                {
                    if (typeof(T).GetTypeInfo().GetCustomAttributes(typeof(SugarTable), true).FirstOrDefault((x => x.GetType() == typeof(SugarTable))) is SugarTable sugarTable && !string.IsNullOrEmpty(sugarTable.TableDescription))
                    {
                        _dbBaseTmp.ChangeDatabase(sugarTable.TableDescription.ToLower());
                    }
                    else
                    {
                        _dbBaseTmp.ChangeDatabase(MainDB.CurrentDbConnId.ToLower());
                    }
                }

                return _dbBaseTmp;
            }
        }

        public SqlSugarScope Db
        {
            get { return _db; }
        }





        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbBaseTmp = unitOfWork.GetDbClient();
        }

        public SqlSugarScope GetSqlSugarScope()
        {
            return _db;
        }



        #region 新增


        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns>影响行数</returns>
        public async Task<int> Add_ReturnCommand(T model)
        {
            return await _db.Insertable(model).ExecuteCommandAsync();
        }
        public async Task<int> AddList(List<T> models)
        {
            return await _db.Insertable(models).ExecuteCommandAsync();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns>返回主键</returns>
        public async Task<int> Add_ReturnIdentity(T model)
        {
            return await _db.Insertable(model).ExecuteReturnIdentityAsync();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns>返回实体</returns>
        public async Task<T> Add_ReturnEntity(T model)
        {
            return await _db.Insertable(model).ExecuteReturnEntityAsync();
        }
        #endregion


        #region 删除


        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="ids">要删除的Id数组</param>
        /// <returns>删除条目数</returns>
        public async Task<int> DeleteByIds(object[] ids)
        {
            return await _db.Deleteable<T>().In(ids).ExecuteCommandAsync();
        }


        public async Task<int> DeleteByWhere(Expression<Func<T, bool>> whereLambda)
        {
            return await _db.Deleteable<T>().Where(whereLambda).ExecuteCommandAsync();
        }
        #endregion

        #region 修改
        /// <summary>
        /// 批量更新方法
        /// </summary>
        /// <param name="whereLambda">需要更新的数据源</param>
        /// <param name="upModel">要更新的字段</param>
        /// <returns>受影响条目数</returns>
        public async Task<int> ModifyBy_GaoXiao(Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> upModel)
        {
            return await _db.Updateable<T>().SetColumns(upModel).Where(whereLambda).ExecuteCommandAsync();
        }
        #endregion

        #region 查询

        /// <summary>
        /// 返回查询实体(还未查询数据库)
        /// var exp= Expressionable.Create<Student>();
        ///exp.OrIF(条件, it=>it.Id==1);//.OrIf 是条件成立才会拼接OR
        ///exp.Or(it =>it.Name.Contains("jack"));//拼接OR
        ///var list = db.Queryable<Student>().Where(exp.ToExpression()).ToList();
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns>结果集的sql语句</returns>
        public ISugarQueryable<T> GetIQueryableObjBy(Expression<Func<T, bool>> whereLambda)
        {
            return _db.Queryable<T>().Where(whereLambda);
        }


        /// <summary>
        /// 返回查询实体(还未查询数据库)
        /// var exp= Expressionable.Create<Student>();
        ///exp.OrIF(条件, it=>it.Id==1);//.OrIf 是条件成立才会拼接OR
        ///exp.Or(it =>it.Name.Contains("jack"));//拼接OR
        ///var list = db.Queryable<Student>().Where(exp.ToExpression()).ToList();
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns>结果集的sql语句</returns>
        public async Task<List<T>> GetIQueryableObjByFirst(Expression<Func<T, bool>> whereLambda)
        {
            return await _db.Queryable<T>().Where(whereLambda).ToListAsync();
        }


        /// <summary>
        /// 5.3 根据条件返回数量
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns>数量</returns>
        public async Task<int> GetCountBy(Expression<Func<T, bool>> whereLambda)
        {
            return await _db.Queryable<T>().Where(whereLambda).CountAsync();
        }

        public async Task<List<TResult>> QueryMuch<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = default) where T1 : class, new()
        {
            if (whereLambda == null)
            {
                return await _db.Queryable(joinExpression).Select(selectExpression).ToListAsync();
            }
            return await _db.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).ToListAsync();
        }

        public async Task<List<TResult>> QueryMuch<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression, Expression<Func<T1, T2, T3, bool>> whereLambda = default) where T1 : class, new()
        {
            if (whereLambda == null)
            {
                return await _db.Queryable(joinExpression).Select(selectExpression).ToListAsync();
            }
            return await _db.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).ToListAsync();
        }

        public async Task<List<TResult>> QueryMuch<T1, T2, T3, T4, TResult>(Expression<Func<T1, T2, T3, T4, object[]>> joinExpression, Expression<Func<T1, T2, T3, T4, TResult>> selectExpression, Expression<Func<T1, T2, T3, T4, bool>> whereLambda = default) where T1 : class, new()
        {
            if (whereLambda == null)
            {
                return await _db.Queryable(joinExpression).Select(selectExpression).ToListAsync();
            }
            return await _db.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).ToListAsync();
        }

        public async Task<int> ExcuteSql(string sql)
        {
            return await _db.Ado.ExecuteCommandAsync(sql);
        }

        public async Task<DataTable> ExcuteSqlToDT(string sql)
        {
            return await _db.Ado.GetDataTableAsync(sql);
        }


        #endregion

    }
}
