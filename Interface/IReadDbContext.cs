
using SEA_ApiTest.Models.Impl;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;
using SEA_ApiTest.Utils;

namespace SEA_ApiTest.Models
{
    public interface IReadDbContext:IDbContextSet
    {
    }

    public static class ReadDbExt
    {
        public static List<T> SqlQuery<T>(this IReadDbContext input,string sql) where T : class,new()
        {
            var db = input.DbContext().Database;
            using (var command =db.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                db.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    var list = new List<T>();
                    var listColumns = typeof(T).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).ToList();
                    while (reader.Read())
                    {
                        var newObject = new T();// Activator.CreateInstance<T>();
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var name = reader.GetName(i);
                            PropertyInfo? prop = listColumns.FirstOrDefault(a => a.Name.ToLower().Equals(name.ToLower()));
                            if (prop == null)
                                continue;

                            try
                            {

                                var val = reader.IsDBNull(i) ? null : reader[i];
                                Type pType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                                prop.SetValue(newObject, Convert.ChangeType(val, pType), null);
                            }
                            catch (Exception e)
                            {
                                Log.d($"property name->{name}  error->{e}");
                            }

                        }
                        list.Add(newObject);
                    }

                    return list;
                }
            }
        }

        public static List<T> SqlQuery<T>(this IReadDbContext input,params object[] args) where T :class,IStoredProcedureModel, new()
        {
            var cmd = string.Format(new T().Cmd(), args);
            return input.SqlQuery<T>(cmd);
        }
    }
}
