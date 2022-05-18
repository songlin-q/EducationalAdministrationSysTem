using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationalAdministrationSysTem.API.IServices.Base
{
    public interface IBaseServices<T> where T : class
    {

        SqlSugarScope GetSqlSugarScope();

        Task<int> Add_ReturnCommand(T model);
        Task<int> AddListAsync(List<T> models);

        Task<int> Add_ReturnIdentity(T model);

        Task<T> Add_ReturnEntity(T model);

        Task<int> DeleteByIds(object[] ids);
        Task<int> DeleteByWhere(Expression<Func<T, bool>> whereLambda);

        Task<int> ModifyBy_GaoXiao(Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> upModel);

        ISugarQueryable<T> GetIQueryableObjBy(Expression<Func<T, bool>> whereLambda);
        Task<List<T>> GetIQueryableObjByFirst(Expression<Func<T, bool>> whereLambda);

        Task<int> GetCountBy(Expression<Func<T, bool>> whereLambda);



        Task<List<TResult>> QueryMuch<T, T2, TResult>(
        Expression<Func<T, T2, object[]>> joinExpression,
        Expression<Func<T, T2, TResult>> selectExpression,
        Expression<Func<T, T2, bool>> whereLambda = null) where T : class, new();

        Task<List<TResult>> QueryMuch<T, T2, T3, TResult>(
          Expression<Func<T, T2, T3, object[]>> joinExpression,
          Expression<Func<T, T2, T3, TResult>> selectExpression,
          Expression<Func<T, T2, T3, bool>> whereLambda = null) where T : class, new();

        Task<List<TResult>> QueryMuch<T, T2, T3, T4, TResult>(
      Expression<Func<T, T2, T3, T4, object[]>> joinExpression,
      Expression<Func<T, T2, T3, T4, TResult>> selectExpression,
      Expression<Func<T, T2, T3, T4, bool>> whereLambda = null) where T : class, new();


    }
}
