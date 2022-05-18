using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.Base;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.Services.Base
{
    public class BaseServices<T>:IBaseServices<T> where T : class, new()
    {
        public IBaseRepository<T> baseDal;


        public SqlSugarScope GetSqlSugarScope()
        {
            return baseDal.GetSqlSugarScope();
        }

        #region 新增
        /// <summary>
        /// 新增（返回新增条目数）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> Add_ReturnCommand(T model)
        {
            return await baseDal.Add_ReturnCommand(model);
        }
        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task<int> AddListAsync(List<T> models)
        {
            return await baseDal.AddList(models);
        }
        /// <summary>
        /// 新增（返回主键）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> Add_ReturnIdentity(T model)
        {
            return await baseDal.Add_ReturnIdentity(model);
        }
        /// <summary>
        /// 新增（返回实体）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> Add_ReturnEntity(T model)
        {
            return await baseDal.Add_ReturnEntity(model);
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
            return await baseDal.DeleteByIds(ids);
        }

        public async Task<int> DeleteByWhere(Expression<Func<T, bool>> whereLambda)
        {
            return await baseDal.DeleteByWhere(whereLambda);
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
            return await baseDal.ModifyBy_GaoXiao(whereLambda, upModel);
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
            return baseDal.GetIQueryableObjBy(whereLambda);
        }

        public Task<List<T>> GetIQueryableObjByFirst(Expression<Func<T, bool>> whereLambda)
        {
            return baseDal.GetIQueryableObjByFirst(whereLambda);
        }



        /// <summary>
        /// 5.3 根据条件返回数量
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns>数量</returns>
        public async Task<int> GetCountBy(Expression<Func<T, bool>> whereLambda)
        {
            return await baseDal.GetCountBy(whereLambda);
        }

        public Task<List<TResult>> QueryMuch<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = default) where T1 : class, new()
        {
            return baseDal.QueryMuch(joinExpression, selectExpression, whereLambda);
        }

        public Task<List<TResult>> QueryMuch<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression, Expression<Func<T1, T2, T3, bool>> whereLambda = default) where T1 : class, new()
        {
            return baseDal.QueryMuch(joinExpression, selectExpression, whereLambda);
        }
        public Task<List<TResult>> QueryMuch<T1, T2, T3, T4, TResult>(Expression<Func<T1, T2, T3, T4, object[]>> joinExpression, Expression<Func<T1, T2, T3, T4, TResult>> selectExpression, Expression<Func<T1, T2, T3, T4, bool>> whereLambda = default) where T1 : class, new()
        {
            return baseDal.QueryMuch(joinExpression, selectExpression, whereLambda);
        }


        #endregion
    }
}
