using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Flow
{
    public interface IFlowController
    {
        IDictionary<string, IEnumerable<IModel>> ReadSource();
        IResult ProcessData<T>(Func<ITaskResult<T>, IDictionary<string,IEnumerable<IModel>>, IDataProcessingResult>) where T : IModel;
    }
}
