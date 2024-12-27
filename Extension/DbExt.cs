using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest
{
    public static class DbExt
    {
        #region Query
        /// <summary>
        /// 使用primary key 查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T? GetModel<T>(this DbContext db, object id) where T : class
        {
            return db.Set<T>().Find(id);
        }
        public static T? First<T>(this DbContext db, Func<T, bool> back) where T : class
            => db.Set<T>().FirstOrDefault(back);
        public static async Task<T?> FirstAsync<T>(this DbContext db, Expression<Func<T, bool>> back) where T : class
            => await db.Set<T>().FirstOrDefaultAsync(back);

        public static IQueryable<T> Where<T>(this DbContext db, Expression<Func<T, bool>> back) where T : class
            => db.Set<T>().Where(back);

        public static async Task<IQueryable<T>> WhereAsync<T>(this DbContext db, Expression<Func<T, bool>> back) where T : class
            => await Task.Run(() => db.Set<T>().Where(back));
        #endregion


        public static List<T> GetList<T>(this DbContext db, Expression<Func<T, bool>>? back = null) where T : class
            => back == null ? db.Set<T>().ToList() : db.Where(back).ToList();
        public static async Task<List<T>> GetListAsync<T>(this DbContext db, Expression<Func<T, bool>>? back = null) where T : class
            => back == null ? await db.Set<T>().ToListAsync() : await db.Where(back).ToListAsync();

        public static int Count<T>(this DbContext db) where T : class
            => db.Set<T>().Count();
        public static int Count<T>(this DbContext db, Expression<Func<T, bool>> back) where T : class
            => db.Set<T>().Where(back).Count();
    }
}
