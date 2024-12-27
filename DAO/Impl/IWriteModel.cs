using SEA_ApiTest.DAO.DTO;
using SEA_ApiTest.Models;
using SEA_ApiTest.Models.Impl;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using SEA_ApiTest.Utils;

namespace SEA_ApiTest.DAO
{

    /// <summary>
    /// 用來指定_dbw的操作(廣泛的)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWriteModel<T>where T : class
    {
        DbContext dbw { get;}
        DbSet<T> WriteDbSet();
    }

    public static class WriteModelExten
    {
        public static bool Insert<T>(this IWriteModel<T> impl,T data)where T : class
        {
            try
            {
                if (data.hasInterface<IDbModelFeature>())
                {
                    var pks = (data as IDbModelFeature).PKS();
                    //Log.print($"Insert data pks->{pks.toJsonString()}");
                    var exist = impl.WriteDbSet().ToList()
                        .Any(d => (d as IDbModelFeature).PKS().Any(d1 => pks.Contains(d1)));

                    //Log.print($"Old exist->{exist?.toJsonString()}");
                    //var dd = impl.WriteDbSet().Attach(data);
                    //Log.print($"Attach data State->{dd.State}");
                    if (exist)
                    {
                        impl.WriteDbSet().Update(data);
                        return impl.dbw.SaveChanges() > 0;
                    }
                }
                impl.WriteDbSet().Add(data);

                return impl.dbw.SaveChanges() > 0;
            }
            catch(Exception e)
            {
                Log.print($"Insert Error->{e}");
            }
            return false;
        }
        public static int InsertList<T>(this IWriteModel<T>impl,IEnumerable<T> list)where T : class
        {
            try
            {
                impl.WriteDbSet().AddRange(list);
                return impl.dbw.SaveChanges();
            }
            catch(Exception e)
            {
                Log.print($"InsertList Error->{e}");
            }
            return -1;
        }
        /// <summary>
        /// 取得要修改的Model
        /// </summary>
        /// <param name="uid">primary key</param>
        /// <returns></returns>
        public static T? GetWriteModel<T>(this IWriteModel<T> impl,object uid)where T:class
        {
            return impl.WriteDbSet().Find(uid);
        }
        public static List<T> GetWriteList<T>(this IWriteModel<T> impl, Expression<Func<T, bool>>? back = null) where T : class
        {
            return impl.WriteDbSet().where(back).ToList();
        }
        public static List<T> GetWriteList<T>(this IWriteModel<T> impl, DbQuery<T> query) where T : class
        {
            return query.Result(impl.WriteDbSet());
        }
        public static Task<List<T>> GetWriteListAsync<T>(this IWriteModel<T> impl, Expression<Func<T, bool>>? back = null) where T : class
        {
            return impl.WriteDbSet().where(back).ToListAsync();
        }
        public static Task<List<T>> GetWriteListAsync<T>(this IWriteModel<T> impl, DbQuery<T> query) where T : class
        {
            return query.ResultAsync(impl.WriteDbSet());
        }

        public static bool Update<T>(this IWriteModel<T> impl, T model) where T : class
        {
            try
            {
                impl.WriteDbSet().Update(model);
                return impl.dbw.SaveChanges() > 0;
            }
            catch(Exception e)
            {
                Log.print($"Update Error->{e}");
            }
            return false;
        }
        public static bool Update<T>(this IWriteModel<T> impl,object pk ,Action<T?> back) where T : class
        {
            try
            {
                var m = impl.GetWriteModel(pk);
                back(m);
                if (m == null)
                    return false;
                return impl.dbw.SaveChanges() > 0;
            }
            catch(Exception e)
            {
                Log.print($"Update Error->{e}");
            }
            return false;
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns>受影響數</returns>
        public static int UpdateList<T>(this IWriteModel<T> impl,IEnumerable<T> list)where T : class
        {
            try
            {
                impl.WriteDbSet().UpdateRange(list);
                return impl.dbw.SaveChanges();
            }
            catch(Exception e)
            {
                Log.print($"UpdateList Error->{e}");
            }
            return -1;
        }
        public static int UpdateList<T>(this IWriteModel<T> impl, DbQuery<T> query) where T : class
        {
            try
            {
                var list = query.Result(impl.WriteDbSet());
                foreach (var item in list)
                    query.Update?.Invoke(item);
                return impl.UpdateList(list);
            }
            catch(Exception e)
            {
                Log.print($"UpdateList Error->{e}");
            }
            return -1;
        }

        public static bool Delete<T>(this IWriteModel<T> impl, object key) where T : class
        {
            try
            {
                return impl.Delete(impl.GetWriteModel(key)!);
            }
            catch(Exception e)
            {
                Log.print($"Delete Error->{e}");
            }
            return false;
        }

        public static bool Delete<T>(this IWriteModel<T> impl,T data)where T : class
        {
            try
            {
                impl.WriteDbSet().Remove(data);
                return impl.dbw.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Log.print($"Delete Error->{e}");
            }
            return false;
        }
        public static int DeleteAll<T>(this IWriteModel<T> impl) where T : class
        {
            try
            {
                var set = impl.WriteDbSet();
                impl.WriteDbSet().RemoveRange(set);
                return impl.dbw.SaveChanges();
            }
            catch (Exception e)
            {
                Log.print($"DeleteAll Error->{e}");
            }
            return -1;
        }
        public static Task<int> DeleteAllAsync<T>(this IWriteModel<T> impl) where T : class
        {
            try
            {
                var set = impl.WriteDbSet();
                impl.WriteDbSet().RemoveRange(set);
                return impl.dbw.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Log.print($"DeleteAllAsync Error->{e}");
            }
            return Task.FromResult(-1);
        }
        public static int DeleteList<T>(this IWriteModel<T>impl,IEnumerable<T> list)where T : class
        {
            try
            {
                impl.WriteDbSet().RemoveRange(list);
                return impl.dbw.SaveChanges();
            }
            catch (Exception e)
            {
                Log.print($"DeleteList Error->{e}");
            }
            return -1;
        }
        public static int DeleteList<T>(this IWriteModel<T> impl, Expression<Func<T, bool>>? back = null) where T : class
        {
            try
            {
                impl.WriteDbSet().RemoveRange(impl.WriteDbSet().where(back));
                return impl.dbw.SaveChanges();
            }
            catch (Exception e)
            {
                Log.print($"DeleteList Error->{e}");
            }
            return -1;
        }
        public static Task<int> DeleteListAsync<T>(this IWriteModel<T> impl, IEnumerable<T> list) where T : class
        {
            try
            {
                impl.WriteDbSet().RemoveRange(list);
                return impl.dbw.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Log.print($"DeleteListAsync Error->{e}");
            }
            return Task.FromResult(-1);
        }
        public static Task<int> DeleteListAsync<T>(this IWriteModel<T> impl,Expression<Func<T,bool>>? back=null)where T : class
        {
            try
            {
                impl.WriteDbSet().RemoveRange(impl.WriteDbSet().where(back));
                return impl.dbw.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Log.print($"DeleteListAsync Error->{e}");
            }
            return Task.FromResult(-1);
        }

        /// <summary>
        /// 單一更新才使用
        /// </summary>
        /// <returns></returns>
        public static int SaveWriteChange<T>(this IWriteModel<T>impl)where T : class
        {
            return impl.dbw.SaveChanges();
        }
        public static Task<int> SaveWriteChangeAsync<T>(this IWriteModel<T>impl)where T : class
        {
            return impl.dbw.SaveChangesAsync();
        }
    }
}
