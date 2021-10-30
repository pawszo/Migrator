using System;
using System.Collections.Generic;

namespace Migrator.ApplicationLayer.DataAccess
{
    public interface IDataItem
    {
        object Origin { get; }
        DateTime CreatedAt { get; }
        IDictionary<string, T> GetFields<T>();
    }
}
