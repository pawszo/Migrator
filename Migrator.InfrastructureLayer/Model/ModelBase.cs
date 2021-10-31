using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.InfrastructureLayer.Model
{
    public abstract class ModelBase : IModel
    {
        public string Id { get; }

        public string Symbol { get; }

        public string Name { get; }

        public IEnumerable<IFeature> Features { get; }

        public IDictionary<string, IAttribute> Attributes { get; }

        public int Version { get; }

        protected ModelBase(string id, string symbol, string name, int version = 1)
        {
            Id = id;
            Symbol = symbol;
            Name = name;
            Version = version;
            Features = new List<IFeature>();
            Attributes = new List<IAttribute>();
        }

        protected ModelBase(string id, string symbol, string name, IEnumerable<IFeature> features, int version = 1) : this(id, symbol, name, version)
        {
            Features = features;
        }

        protected ModelBase(string id, string symbol, string name, IEnumerable<IFeature> features, int version = 1) : this(id, symbol, name, version)
        {
            Features = features;
        }
    }
}
