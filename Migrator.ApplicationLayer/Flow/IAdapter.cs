using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Flow
{
    public interface IAdapter<T> where T : IDomainItem
    {
        IEnumerable<T> GetAll();
        IEnumerable<IUpdateResult> UpdateAll(IEnumerable<T> items);
    }
}
