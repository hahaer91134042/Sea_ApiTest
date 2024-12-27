using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisFreebetLotteryDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisFreebetLottery>, IWriteModel<LabelStatisFreebetLottery>
    {
        public LabelStatisFreebetLotteryDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisFreebetLottery> ReadDbSet() => _dbr.LabelStatisFreebetLotteries;

        public DbSet<LabelStatisFreebetLottery> WriteDbSet() => _dbw.LabelStatisFreebetLotteries;
    }
}
