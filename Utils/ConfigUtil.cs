using SEA_ApiTest.Models;
using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace SEA_ApiTest.Utils
{
    public class ConfigUtil
    {
        public static ConfigUtil Instance;

        public static ConfigUtil Start(IConfigurationRoot config=null)
        {
            if(Instance!=null)
                return Instance;

            Instance = config == null ? new ConfigUtil() : new ConfigUtil(config);

            return Instance;
        }

        //暫時沒用
        //private IConfigurationBuilder builder;
        private IConfigurationRoot config;

        private ConfigUtil()
        {
            string? environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            //builder = new ConfigurationBuilder()
            //              .SetBasePath(Directory.GetCurrentDirectory())
            //              .AddJsonFile("appsettings.json", true, false)
            //              .AddJsonFile($"appsettings.{environment}.json", true, false);
            config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", true, false)
              .AddJsonFile($"appsettings.{environment}.json", true, false).Build();
            //config = builder.Build();
        }
        private ConfigUtil(IConfigurationRoot root)
        {
            config= root;
        }

        public T CreatDbContext<T>()where T:DbContext,IDbContextSet
        {
            var dbType = typeof(T);

            var set = dbType.getAttribute<DbContextConfigAttr>();
            if (set == null)
                throw new NullReferenceException($"DbContext Class Must Use Attritube {typeof(DbContextConfigAttr).Name}");

            //var methodSqlPath = typeof(IDbContextSet).GetMethod(nameof(IDbContextSet.SqlConnectConfigPath))!
            //    .MakeGenericMethod(dbType);
            //var methodVerPath = typeof(IDbContextSet).GetMethod(nameof(IDbContextSet.DbVerConfigPath))!
            //    .MakeGenericMethod(dbType);            

            return (T)Activator.CreateInstance(dbType,
                new DbContextOptionsBuilder<T>()
                .UseMySql(Get(set.sqlPath), ServerVersion.Parse(Get(set.verPath)))
                .Options)!;
            //return new DAWriteDbContext(new DbContextOptionsBuilder<DAWriteDbContext>()
            //    .UseMySql(Get("SQLConnection:Authorizedb:Write"),
            //    ServerVersion.Parse(Get("ServerVersion:Authorizedb:Write")))
            //    .Options);
        }

        //public DAReadDbContext GetReadDb()
        //{
        //    return new DAReadDbContext(new DbContextOptionsBuilder<DAReadDbContext>()
        //        .UseMySql(Get("SQLConnection:Authorizedb:Write"), ServerVersion.Parse(Get("ServerVersion:Authorizedb:Write")))
        //        .Options);
        //}

        public string Get(string key)
        {
            return config[key];
        }
    }
}