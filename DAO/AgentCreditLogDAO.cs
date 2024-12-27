using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AgentCreditLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<AgentCreditLog>, IWriteModel<AgentCreditLog>
    {
        public AgentCreditLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<AgentCreditLog> ReadDbSet() => _dbr.AgentCreditLogs;

        public DbSet<AgentCreditLog> WriteDbSet() => _dbw.AgentCreditLogs;
    }
}
