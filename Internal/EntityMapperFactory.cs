
// 



// 
using System;

namespace Jiesen.DapperPoco.Internal
{
    public class EntityMapperFactory
    {
        private readonly ConcurrentCache<RuntimeTypeHandle, IEntityMapper> _entityMappers = new ConcurrentCache<RuntimeTypeHandle, IEntityMapper>();

        static EntityMapperFactory()
        {
            Instance = new EntityMapperFactory();
        }

        private EntityMapperFactory()
        {
        }

        public static EntityMapperFactory Instance { get; }

        public IEntityMapper GetEntityMapper(Jiesen.DapperPoco.DbContext dbCtx)
        {
            var key = dbCtx.GetType().TypeHandle;
            return _entityMappers.GetOrAdd(key, () =>
            {
                var eBuilder = new EntitiesBuilder();
                dbCtx.OnEntitiesBuilding(eBuilder);

                return new DefaultEntityMapper(eBuilder.Build());
            });
        }
    }
}
