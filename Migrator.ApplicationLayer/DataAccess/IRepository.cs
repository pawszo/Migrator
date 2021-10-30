using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.DataAccess
{
    public interface IRepository<T> where T : IModel
    {
        IEnumerable<T> GetAll(IEnumerable<IParameter> parameters);

    }
}
