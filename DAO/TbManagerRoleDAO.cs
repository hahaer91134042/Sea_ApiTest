using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{
    public class TbManagerRoleDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<TbManagerRole>,IWriteModel<TbManagerRole>
    {
        public TbManagerRoleDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<TbManagerRole> ReadDbSet()=>_dbr.TbManagerRoles;

        public DbSet<TbManagerRole> WriteDbSet() => _dbw.TbManagerRoles;
    }
}
