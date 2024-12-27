using SEA_ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace SEA_ApiTest.Models
{
    public interface IDbContextSet
    {
        //string SqlConnectConfigPath();
        //string DbVerConfigPath();
        DbContext DbContext();
    }
    public static class IDbContextSetExt
    {
        public static int ExecuteSql(this IDbContextSet input,string sql)
        {
            var db = input.DbContext().Database;
            using (var command = db.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                db.OpenConnection();
                return command.ExecuteNonQuery();
            }
         }        
    }
}
