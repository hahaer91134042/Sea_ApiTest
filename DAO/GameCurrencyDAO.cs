using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{
    public class GameCurrencyDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<GameCurrency>,IWriteModel<GameCurrency>
    {
        public GameCurrencyDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<GameCurrency> ReadDbSet()=>_dbr.GameCurrencies;

        public DbSet<GameCurrency> WriteDbSet()=>_dbw.GameCurrencies;
    }
}
