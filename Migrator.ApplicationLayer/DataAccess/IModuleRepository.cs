using Migrator.ApplicationLayer.Model;
using System.Collections.Generic;

namespace Migrator.ApplicationLayer.DataAccess
{
    public interface IModuleRepository<T> where T : ICommonModel
    {
        IEnumerable<T> GetAll(IEnumerable<IAttribute> attributes);
        bool Save(T moduleObject);
        bool SaveAll(IEnumerable<T> moduleObjects);
    }
}