using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisGameOnlineDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisGameOnline>, IWriteModel<LabelStatisGameOnline>
    {
        public LabelStatisGameOnlineDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisGameOnline> ReadDbSet() => _dbr.LabelStatisGameOnlines;

        public DbSet<LabelStatisGameOnline> WriteDbSet()=>_dbw.LabelStatisGameOnlines;
    }
}
