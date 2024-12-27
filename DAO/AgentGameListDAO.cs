using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AgentGameListDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<AgentGameList>, IWriteModel<AgentGameList>
    {
        public AgentGameListDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public AgentGameListDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<AgentGameList> ReadDbSet() => _dbr.AgentGameLists;

        public DbSet<AgentGameList> WriteDbSet()=>_dbw.AgentGameLists;
    }
}
