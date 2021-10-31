using System;
using System.Collections.Generic;

namespace Migrator.ApplicationLayer.DataAccess
{
    public interface IDataItem
    {
        object Origin { get; }
        DateTime CreatedAt { get; }
        IReadOnlyDictionary<string, object> ValuePairs { get;  }
        bool AddValue<T>(T value, string key);
        IReadOnlyCollection<string> Keys { get; }
    }
}
