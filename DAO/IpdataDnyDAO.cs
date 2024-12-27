using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class IpdataDnyDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<IpdataDny>, IWriteModel<IpdataDny>
    {
        public IpdataDnyDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        

        public DbContext dbw => _dbw;

        public DbSet<IpdataDny> ReadDbSet() => _dbr.IpdataDnies;

        public DbSet<IpdataDny> WriteDbSet()=>_dbw.IpdataDnies;


    }
}
