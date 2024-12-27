using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.Models
{
    public interface IWriteDbContext:IDbContextSet
    {

    }

    public static class WriteDbExt
    {
        #region Insert
        public static bool Insert<T>(this IWriteDbContext instance , T data) where T : class
        {
            var context = instance.DbContext();
            context.Set<T>().Add(data);
            return context.SaveChanges() > 0;
        }

        public static async Task<bool> InsertAsync<T>(this IWriteDbContext instance, T data) where T : class
        {
            var context = instance.DbContext();
             context.Set<T>().Add(data);
            return await context.SaveChangesAsync() > 0;
        }
        #endregion

        #region Update
        public static int UpdateList<T>(this IWriteDbContext instance, IEnumerable<T> list) where T : class
        {
            var context = instance.DbContext();
            foreach (T item in list)
            {
                 context.Set<T>().Update(item);
                //Set<T>().Attach(item);
                //Entry(item).State = EntityState.Modified;
            }
            return context.SaveChanges();
        }
        #endregion

        #region Delete
        public static bool Delete<T>(this IWriteDbContext instance, T model) where T : class
        {
            var context = instance.DbContext();
             context.Set<T>().Remove(model);
            return context.SaveChanges() > 0;
        }
        public static int DeleteList<T>(this IWriteDbContext instance, IEnumerable<T> list) where T : class
        {
            var context = instance.DbContext();
            foreach (T item in list)
            {
                context.Set<T>().Attach(item);
                context.Entry(item).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }
        #endregion
    }
}
