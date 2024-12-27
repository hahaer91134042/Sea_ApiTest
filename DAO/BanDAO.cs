using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class BanDAO : BaseDAO<Tp01ReadDb, Tp01WriteDb>, IReadModel<Ban>, IWriteModel<Ban>
    {
        public BanDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Ban> ReadDbSet() => _dbr.Bans;

        public DbSet<Ban> WriteDbSet() => _dbw.Bans;

        public bool UnBan(List<long> ids)
        {
            //var list = _dbw.Bans.Where(m => ids.Contains((long)m.PlayerId)).ToList();
            foreach (var model in _dbw.Bans.Where(m => ids.Contains((long)m.PlayerId)))
            {
                model.LoginTime = Convert.ToDateTime("1971-1-1");
                //main.ban.Attach(model);
                //_dbw.Entry(model).State = EntityState.Modified;
            }
            return _dbw.SaveChanges() > 0;
        }

    }
}
