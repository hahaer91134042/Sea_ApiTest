using SEA_ApiTest;
using SEA_ApiTest.DAO.DTO;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{

    /// <summary>
    /// 用來指定_dbr的操作
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadModel<T>where T : class
    {
        //T? GetReadModel(object uid);
        //List<T> GetReadList(Expression<Func<T, bool>>? back = null);
        //Task<List<T>>  GetReadListAsync(Expression<Func<T, bool>>? back = null);

        DbSet<T> ReadDbSet();
    }

    public static class ReadModelExten
    {
        public static T? GetReadModel<T>(this IReadModel<T> impl, object uid)where T : class
        {
            return impl.ReadDbSet().Find(uid);
        }
        public static List<T> GetReadList<T>(this IReadModel<T> impl, Expression<Func<T, bool>>? back = null)where T : class
        {
            return impl.ReadDbSet().where(back).ToList();
        }
        public static List<T> GetReadList<T>(this IReadModel<T> impl, DbQuery<T> query) where T : class
        {
            return query.Result(impl.ReadDbSet());
        }
        public static Task<List<T>> GetReadListAsync<T>(this IReadModel<T> impl,Expression<Func<T, bool>>? back = null)where T : class
        {
            return impl.ReadDbSet().where(back).ToListAsync();
        }

        public static Task<List<T>> GetReadListAsync<T>(this IReadModel<T> impl,DbQuery<T> query ) where T : class
        {
            return query.ResultAsync(impl.ReadDbSet());
        }
        public static int ReadCount<T>(this IReadModel<T> impl, Expression<Func<T, bool>>? back = null) where T : class
        {
            if (back == null)
                return impl.ReadDbSet().Count();
            return impl.ReadDbSet().Count(back);
        }
        public static Task<int> ReadCountAsync<T>(this IReadModel<T> impl, Expression<Func<T, bool>>? back = null) where T : class
        {
            return Task.Run(() => impl.ReadCount(back));
        }
        public static int ReadCount<T>(this IReadModel<T> impl, DbQuery<T> query) where T : class
        {
            IQueryable<T> result = impl.ReadDbSet();
            foreach (var where in query)
                result = result.Where(where);
            return result.Count();
        }
        public static Task<int> ReadCountAsync<T>(this IReadModel<T> impl,DbQuery<T> query)where T : class
        {
            return Task.Run(() => impl.ReadCount(query));
        }
    }
}
