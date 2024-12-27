using SEA_ApiTest.Models;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{
    public class TbManagerRoleValueDAO : BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<TbManagerRoleValue>,IWriteModel<TbManagerRoleValue>
    {
        public TbManagerRoleValueDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }

        public TbManagerRoleValueDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public Task<List<TbManagerRoleValue>> GetList()
        {
            return _dbr.TbManagerRoleValues.ToListAsync();
        }

        public bool hasPermission(int role_type, string nav_name, string action)
        {
            try
            {
                var permission = _dbr.TbManagerRoleValues.Where(m => m.RoleId == role_type && m.NavName == nav_name && m.Action == action).Count();
                return permission > 0;
            }
            catch { return false; }
        }


        public DbContext dbw => _dbw;
        public DbSet<TbManagerRoleValue> ReadDbSet() => _dbr.TbManagerRoleValues;
        public DbSet<TbManagerRoleValue> WriteDbSet() => _dbw.TbManagerRoleValues;
    }
}
