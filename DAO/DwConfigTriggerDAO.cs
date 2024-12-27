using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwConfigTriggerDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwConfigTrigger>, IWriteModel<DwConfigTrigger>
    {
        public DwConfigTriggerDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwConfigTrigger> ReadDbSet() => _dbr.DwConfigTriggers;

        public DbSet<DwConfigTrigger> WriteDbSet()=>_dbw.DwConfigTriggers;
    }
}
