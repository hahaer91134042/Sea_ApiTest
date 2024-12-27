using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisFreebetDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisFreebet>, IWriteModel<StatisFreebet>
    {
        public StatisFreebetDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisFreebet> ReadDbSet() => _dbr.StatisFreebets;

        public DbSet<StatisFreebet> WriteDbSet()=>_dbw.StatisFreebets;
    }
}
