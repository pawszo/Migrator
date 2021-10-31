using Migrator.ApplicationLayer.Flow;
using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.InfrastructureLayer.Flow
{
    public class FlowController : IFlowController
    {
        public IResult ProcessData<T>(Func<ITaskResult<T>, IDictionary<string, IEnumerable<IModel>>, IDataProcessingResult> ) where T : IModel
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, IEnumerable<IModel>> ReadSource()
        {
            throw new NotImplementedException();
        }
    }
}
