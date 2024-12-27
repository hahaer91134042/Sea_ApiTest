using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisProfitUserDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisProfitUser>, IWriteModel<LabelStatisProfitUser>
    {
        public LabelStatisProfitUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisProfitUser> ReadDbSet() => _dbr.LabelStatisProfitUsers;

        public DbSet<LabelStatisProfitUser> WriteDbSet()=>_dbw.LabelStatisProfitUsers;
    }
}
