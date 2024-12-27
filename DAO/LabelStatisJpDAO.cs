using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisJpDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<LabelStatisJp>, IWriteModel<LabelStatisJp>
    {
        public LabelStatisJpDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisJp> ReadDbSet() => _dbr.LabelStatisJps;

        public DbSet<LabelStatisJp> WriteDbSet()=>_dbw.LabelStatisJps;
    }
}
