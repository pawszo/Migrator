using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.DataAccess
{
    public interface IAttribute
    {
        public string InternalId { get; }
        public string Name { get; }
        public IEnumerable<IDataItem> DataItems { get; }

    }
}
