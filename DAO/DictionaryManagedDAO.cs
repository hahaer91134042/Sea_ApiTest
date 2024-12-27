using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DictionaryManagedDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DictionaryManaged>, IWriteModel<DictionaryManaged>
    {
        public DictionaryManagedDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DictionaryManaged> ReadDbSet() => _dbr.DictionaryManageds;

        public DbSet<DictionaryManaged> WriteDbSet()=>_dbw.DictionaryManageds;
    }
}
