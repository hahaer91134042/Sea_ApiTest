using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WebConfigLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<WebConfigLog>, IWriteModel<WebConfigLog>
    {
        public WebConfigLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WebConfigLog> ReadDbSet() => _dbr.WebConfigLogs;

        public DbSet<WebConfigLog> WriteDbSet()=>_dbw.WebConfigLogs;
    }
}
