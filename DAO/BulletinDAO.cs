using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class BulletinDAO : BaseDAO<Tp01ReadDb, Tp01WriteDb>, IReadModel<Bulletin>, IWriteModel<Bulletin>
    {
        public BulletinDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Bulletin> ReadDbSet() => _dbr.Bulletins;

        public DbSet<Bulletin> WriteDbSet() => _dbw.Bulletins;
    }
}
