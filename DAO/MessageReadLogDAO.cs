using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class MessageReadLogDAO :BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<MessageReadLog>,IWriteModel<MessageReadLog>
    {
        public MessageReadLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<MessageReadLog> ReadDbSet() => _dbr.MessageReadLogs;

        public DbSet<MessageReadLog> WriteDbSet()=>_dbw.MessageReadLogs;
    }
}
