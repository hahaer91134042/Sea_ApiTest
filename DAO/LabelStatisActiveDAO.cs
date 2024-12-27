using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisActiveDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisActive>, IWriteModel<LabelStatisActive>
    {
        public LabelStatisActiveDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisActive> ReadDbSet() => _dbr.LabelStatisActives;

        public DbSet<LabelStatisActive> WriteDbSet()=>_dbw.LabelStatisActives;
    }
}
