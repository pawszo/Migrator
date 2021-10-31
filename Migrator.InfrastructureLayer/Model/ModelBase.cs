using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Model;
using System.Collections.Generic;
using System.Linq;

namespace Migrator.InfrastructureLayer.Model
{
    public abstract class ModelBase : IModel
    {
        public string InternalId { get; }

        public string Symbol { get; }

        public string Name { get; }

        public IEnumerable<IFeature> Features { get; }

        public IEnumerable<IAttribute> Attributes { get; }

        public int Version { get; }

        protected ModelBase(string internalId, string symbol, string name, int version = 1, IEnumerable<IFeature> features = null, IEnumerable<IAttribute> attributes = null)
        {
            InternalId = internalId;
            Symbol = symbol;
            Name = name;
            Version = version;
            Features = features ?? new List<IFeature>();
            Attributes = attributes ?? new List<IAttribute>();
        }

        public override string ToString()
        {
            return $"ModelType = {this.GetType()}, Id = {InternalId}, Symbol = {Symbol}, Name = {Name}, Version = {Version}";
        }

        public override bool Equals(object o)
        {
            if(o != null && o is IModel model)
            {
                return InternalId == model.InternalId
                    && Name == model.Name
                    && Symbol == model.Symbol
                    && Version == model.Version
                    && (Features == model.Features || Features != null && Features.SequenceEqual(model.Features))
                    && (Attributes == model.Attributes || Attributes != null && Attributes.SequenceEqual(model.Attributes));
            }

            return false;
        }
    }
}
