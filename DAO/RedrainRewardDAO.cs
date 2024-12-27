using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RedrainRewardDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<RedrainReward>, IWriteModel<RedrainReward>
    {
        public RedrainRewardDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RedrainReward> ReadDbSet() => _dbr.RedrainRewards;

        public DbSet<RedrainReward> WriteDbSet()=>_dbw.RedrainRewards;
    }
}
