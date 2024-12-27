using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class FreebetLotteryDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<FreebetLottery>, IWriteModel<FreebetLottery>
    {
        public FreebetLotteryDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<FreebetLottery> ReadDbSet() => _dbr.FreebetLotteries;

        public DbSet<FreebetLottery> WriteDbSet()=>_dbw.FreebetLotteries;
    }
}
