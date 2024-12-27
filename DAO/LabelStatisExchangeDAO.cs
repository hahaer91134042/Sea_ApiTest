using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisExchangeDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisExchange>, IWriteModel<LabelStatisExchange>
    {
        public LabelStatisExchangeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisExchange> ReadDbSet() => _dbr.LabelStatisExchanges;

        public DbSet<LabelStatisExchange> WriteDbSet()=>_dbw.LabelStatisExchanges;
    }
}
