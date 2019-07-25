
// 


// Created: 2017-02-03
// 
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using Dapper;
using Jiesen.DapperPoco.Utils;

namespace Jiesen.DapperPoco.Adapters
{
    public class SQLiteAdapter : SqlAdapter
    {
        private readonly DbProviderFactory _dbProviderFac;

        public SQLiteAdapter(DbProviderFactory dbProviderFac)
        {
            _dbProviderFac = dbProviderFac;
        }

        public override DbProviderFactory GetFactory()
        {
            return _dbProviderFac;
        }

        public override long Insert(IDbConnection dbConn, string sql, object param, IDbTransaction transaction)
        {
            sql += "; SELECT last_insert_rowid();";
            return dbConn.ExecuteScalar<long>(sql, param, transaction);
        }
    }
}
