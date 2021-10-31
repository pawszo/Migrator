using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Model;
using Migrator.InfrastructureLayer.Model;
using System.Collections.Generic;

namespace Migrator.Modules.Product
{
    public class MigratorProduct : CommonModelBase, ICommonModel
    {
        public MigratorProduct(string internalId, string symbol, string name, int version = 1, IEnumerable<IFeature> features = null, IEnumerable<IAttribute> attributes = null, long? id = null) : base(internalId, symbol, name, version, features, attributes, id)
        {
        }
    }
}
