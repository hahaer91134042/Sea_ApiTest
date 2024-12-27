using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class TbManagerDAO :BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<TbManager>, IWriteModel<TbManager>
    {
        public TbManagerDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<TbManager> ReadDbSet() => _dbr.TbManagers;

        public DbSet<TbManager> WriteDbSet() => _dbw.TbManagers;
    }
}
