using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Enums;
using Migrator.ApplicationLayer.Flow;
using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Logic
{
    public interface ITask
    {
        long? Id { get; }
        string Name { get; }
        DateTime CreatedAt { get; }
        DateTime? RunAt { get; set; }
        Severity Severity { get; set; }
        IEnumerable<IDataItem> Data { get; }
        IEnumerable<object> ModuleObjects { get; }
        Queue<Func<IEnumerable<IDataItem>, object, ITaskResult>> SubtaskSequence { get; }

        /// <summary>
        /// Used by service when it accepts adding the task
        /// </summary>
        /// <param name="id">Unique id provided by the task service</param>
        /// <returns></returns>
        void RegisterId(long id);
    }
    public interface ITask<T> : ITask where T : IModel
    {
        new IEnumerable<T> ModuleObjects { get; }
        new Queue<Func<IEnumerable<IDataItem>, T, ITaskResult<T>>> SubtaskSequence { get; }
    }
}
