using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Logic
{
    public interface ITaskService
    {
        /// <summary>
        /// Add task to task queue
        /// </summary>
        /// <typeparam name="T">Type of object which this task is related to</typeparam>
        /// <param name="task"></param>
        /// <returns>orderNumber</returns>
        int AddTask<T>(ITask<T> task) where T : IModel;
        ITask
    }
}
