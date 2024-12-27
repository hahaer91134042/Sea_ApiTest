using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisTypeDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisType>, IWriteModel<LabelStatisType>
    {
        public LabelStatisTypeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisType> ReadDbSet() => _dbr.LabelStatisTypes;

        public DbSet<LabelStatisType> WriteDbSet()=>_dbw.LabelStatisTypes;
    }
}
