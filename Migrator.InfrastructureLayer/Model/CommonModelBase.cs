using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Model;
using System.Collections.Generic;

namespace Migrator.InfrastructureLayer.Model
{
    public abstract class CommonModelBase : ModelBase, ICommonModel
    {
        public long? Id { get; protected set; }

        public ICommonModelDetail Detail { get; protected set; }

        protected CommonModelBase (
            string internalId, 
            string symbol, 
            string name, 
            int version = 1, 
            IEnumerable<IFeature> features = null, 
            IEnumerable<IAttribute> attributes = null, 
            long? id = null
            ) : base(internalId, symbol, name, version, features, attributes)
        {
            Id = id;
        }

        public new bool Equals(object o) => base.Equals(o) && Id == (o as ICommonModel).Id;

    }
}
