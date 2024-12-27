using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisProfitUserDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisProfitUser>, IWriteModel<StatisProfitUser>
    {
        public StatisProfitUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisProfitUser> ReadDbSet() => _dbr.StatisProfitUsers;

        public DbSet<StatisProfitUser> WriteDbSet()=>_dbw.StatisProfitUsers;
    }
}
