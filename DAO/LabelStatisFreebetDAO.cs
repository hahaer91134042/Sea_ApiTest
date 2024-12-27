using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisFreebetDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<LabelStatisFreebet>, IWriteModel<LabelStatisFreebet>
    {
        public LabelStatisFreebetDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisFreebet> ReadDbSet() => _dbr.LabelStatisFreebets;

        public DbSet<LabelStatisFreebet> WriteDbSet() => _dbw.LabelStatisFreebets;
    }
}
