using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwRtpLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwRtpLog>, IWriteModel<DwRtpLog>
    {
        public DwRtpLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwRtpLog> ReadDbSet() => _dbr.DwRtpLogs;

        public DbSet<DwRtpLog> WriteDbSet()=>_dbw.DwRtpLogs;
    }
}
