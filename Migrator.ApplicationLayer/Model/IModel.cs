using Migrator.ApplicationLayer.DataAccess;
using System.Collections.Generic;

namespace Migrator.ApplicationLayer.Model
{
    public interface IModel
    {
        string Id { get; }
        string Symbol { get; }
        string Name { get; }
        IEnumerable<IFeature> Features { get; }
        IEnumerable<IAttribute> Attributes { get; }
        int Version { get; }

    }
}
