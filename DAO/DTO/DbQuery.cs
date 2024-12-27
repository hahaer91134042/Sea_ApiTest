using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO.DTO
{
    public class DbQuery<T>:List<Expression<Func<T, bool>>> where T:class
    {
        public DbQuery(params Expression<Func<T, bool>>[] args)
        {
            AddRange(args);
        }

        public int Start { get; set; } = -1;
        public int Length { get; set; } = -1;

        /// <summary>
        /// 單個數值排序使用
        /// </summary>
        public Expression<Func<T, object>>? OrderAsc { get; set; } = null;
        /// <summary>
        /// 單個數值排序使用
        /// </summary>
        public Expression<Func<T, object>>? OrderDesc { get; set; } = null;
        /// <summary>
        /// 多個數值排序使用
        /// </summary>
        public ISortBy<T>? OrderBy = null;

        public Action<T>? Update=null;
        
        //public List<Expression<Func<T,object>>> orderAsc=new List<Expression<Func<T,object>>>();
        //public List<Expression<Func<T, object>>> orderDesc = new List<Expression<Func<T, object>>>();

        //public Task<List<T>> ResultAsync<K>(DbSet<T> set, SortBy<T, K>? sort = null) => Task.Run(() => Result(set,sort));
        //public List<T> Result<K>(DbSet<T> set,SortBy<T,K>? sort=null)
        //{
        //    IQueryable<T> result=set;
        //    foreach (var where in this)
        //        result = result.Where(where);


        //    if (sort != null)
        //        if (sort.GetType().Name == typeof(Asc<T, K>).Name)
        //            result = result.OrderBy(sort.exp);
        //        else
        //            result = result.OrderByDescending(sort.exp);

        //    if (Start != -1)
        //        result = result.Skip(Start);
        //    if (Length != -1)
        //        result = result.Take(Length);

        //    return result.ToList();
        //}


        public Task<List<T>> ResultAsync(DbSet<T> set) => Task.Run(() => Result(set));
        public List<T> Result(DbSet<T> set)
        {
            IQueryable<T> result = set;
            foreach (var where in this)
                result = result.Where(where);

            if(OrderAsc!=null)
                result = result.OrderBy(OrderAsc);
            if(OrderDesc!=null)
                result=result.OrderByDescending(OrderDesc);
            if (OrderBy != null)
            {
                var isAsc = OrderBy.GetType().Name == typeof(Asc<T>).Name;
                IOrderedQueryable<T>? _r = null;

                for (int i = 0; i < OrderBy.Count; i++)
                {
                    if (i == 0)
                    {
                        if (isAsc)
                            _r = result.OrderBy(OrderBy[i]);
                        else
                            _r = result.OrderByDescending(OrderBy[i]);
                        continue;
                    }
                    
                    if(isAsc)
                        _r=_r?.ThenBy(OrderBy[i]);
                    else
                        _r=_r?.ThenByDescending(OrderBy[i]);
                }
                result = _r ?? result;
            }

            if (Start != -1)
                result = result.Skip(Start);
            if (Length != -1)
                result = result.Take(Length);

            return result.ToList();
        }
        public DbQuery<T> AddQuery(Expression<Func<T, bool>> condition)
        {
            Add(condition);
            return this;
        }

    }

    public static class OrderBy<T> where T : class
    {
       
        public static ISortBy<T> Asc(params Expression<Func<T,object>>[] orders)
        {
            return new Asc<T>().Also(s => s.AddRange(orders));
        }
        public static ISortBy<T> Desc(params Expression<Func<T, object>>[] orders) 
        {
            return new Desc<T>().Also(s => s.AddRange(orders));
        }
    }
    
    public abstract class ISortBy<T>:List<Expression<Func<T,object>>>  where T : class
    {

    }

    internal class Asc<T> : ISortBy<T> where T : class
    {        

    }

    internal class Desc<T> : ISortBy<T> where T : class
    {

    }
}
