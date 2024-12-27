using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisFreebetLotteryDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisFreebetLottery>, IWriteModel<StatisFreebetLottery>
    {
        public StatisFreebetLotteryDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisFreebetLottery> ReadDbSet() => _dbr.StatisFreebetLotteries;

        public DbSet<StatisFreebetLottery> WriteDbSet()=>_dbw.StatisFreebetLotteries;
    }
}
