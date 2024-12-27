using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SysBulletinRecordDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SysBulletinRecord>, IWriteModel<SysBulletinRecord>
    {
        public SysBulletinRecordDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SysBulletinRecord> ReadDbSet() => _dbr.SysBulletinRecords;

        public DbSet<SysBulletinRecord> WriteDbSet() => _dbw.SysBulletinRecords;
    }
}
