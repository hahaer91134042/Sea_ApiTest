
using Microsoft.EntityFrameworkCore;
using SEA_ApiTest.Models.Firelog1DB;
using SEA_ApiTest.Models.GameTpiDB;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Models.Tp01DB;
using SEA_ApiTest.Models.Tpi1DB;
using SEA_ApiTest.Utils;

namespace SEA_ApiTest.Models
{
    public class GmDbList
    {
        public List<DbContext> read;
        public List<DbContext> write;

        public GmDbList()
        {
            var util = ConfigUtil.Start();
            read = new List<DbContext>()
            {
                util.CreatDbContext<Firelog1ReadDb>(),
                util.CreatDbContext<GameTpiReadDb>(),
                util.CreatDbContext<ManageReadDb>(),
                util.CreatDbContext<Tp01ReadDb>(),
                util.CreatDbContext<Tpi1ReadDb>()
            };

            write = new List<DbContext>()
            {
                util.CreatDbContext<Firelog1WriteDb>(),
                util.CreatDbContext<GameTpiWriteDb>(),
                util.CreatDbContext<ManageWriteDb>(),
                util.CreatDbContext<Tp01WriteDb>(),
                util.CreatDbContext<Tpi1WriteDb>()
            };

        }

        public T ReadDb<T>() where T : DbContext, IReadDbContext
        {
            var t = typeof(T);
            return (T)read.First(db => db.GetType().Name == t.Name);
        }
        public T WriteDb<T>() where T : DbContext, IWriteDbContext
        {
            var t = typeof(T);
            return (T)write.First(db => db.GetType().Name == t.Name);
        }

    }
}
