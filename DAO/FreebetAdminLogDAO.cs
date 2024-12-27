using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class FreebetAdminLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<FreebetAdminLog>, IWriteModel<FreebetAdminLog>
    {
        public FreebetAdminLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<FreebetAdminLog> ReadDbSet() => _dbr.FreebetAdminLogs;

        public DbSet<FreebetAdminLog> WriteDbSet()=>_dbw.FreebetAdminLogs;
    }
}
