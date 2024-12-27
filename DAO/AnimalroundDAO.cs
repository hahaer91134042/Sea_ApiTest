using SEA_ApiTest.Models.Tpi1DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AnimalroundDAO : BaseDAO<Tpi1ReadDb, Tpi1WriteDb>, IReadModel<Animalround>, IWriteModel<Animalround>
    {
        public AnimalroundDAO(Tpi1WriteDb dbw, Tpi1ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Animalround> ReadDbSet() => _dbr.Animalrounds;

        public DbSet<Animalround> WriteDbSet()=>_dbw.Animalrounds;
    }
}
