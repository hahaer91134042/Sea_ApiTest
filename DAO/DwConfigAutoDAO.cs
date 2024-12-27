using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwConfigAutoDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwConfigAuto>, IWriteModel<DwConfigAuto>
    {
        public DwConfigAutoDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwConfigAuto> ReadDbSet() => _dbr.DwConfigAutos;

        public DbSet<DwConfigAuto> WriteDbSet()=>_dbw.DwConfigAutos;
    }
}
