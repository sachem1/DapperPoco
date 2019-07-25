
// 



// 
using Jiesen.DapperPoco.Adapters;

namespace Jiesen.DapperPoco.Internal
{
    public class DbContextServices: IDbContextServices
    {
        public string ConnectionString { get; set; }
        public ISqlAdapter SqlAdapter { get; set; }
        public IEntityMapper EntityMapper { get; set; }
        public ISqlGenerater SqlGenerater { get; set; }
    }
}
