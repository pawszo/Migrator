using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Enums;
using Migrator.ApplicationLayer.Flow;
using Migrator.ApplicationLayer.Logic;
using Migrator.ApplicationLayer.Model;
using System;
using System.Collections.Generic;

namespace Migrator.InfrastructureLayer.Logic
{
    public abstract class TaskBase : ITask
    {
        public long? Id { get; private set; }

        public string Name { get; }

        public DateTime CreatedAt { get; }

        public DateTime? RunAt { get; set; }
        public Severity Severity { get; set; }

        public IEnumerable<IDataItem> Data { get; }

        public IEnumerable<object> ModuleObjects { get; }

        public Queue<Func<IEnumerable<IDataItem>, object, ITaskResult>> SubtaskSequence { get; }

        protected TaskBase(string name, Severity severity, IEnumerable<IDataItem> data, DateTime? runAt = null)
        {
            Name = name;
            Severity = severity;
            Data = data ?? new List<IDataItem>();
            CreatedAt = DateTime.Now;
            RunAt = runAt;
        }

        public TaskBase(string name, Severity severity, IEnumerable<IDataItem> data = null, IEnumerable<object> moduleObjects = null, DateTime? runAt = null) : this(name, severity, data, runAt)
        {
            ModuleObjects = moduleObjects ?? new List<object>();
            SubtaskSequence = new Queue<Func<IEnumerable<IDataItem>, object, ITaskResult>>();
        }


        public void RegisterId(long id) => Id = id;

        public override string ToString() =>
            $"Task {Name}: Id:{Id}, Name = {Name}, Severity = {Severity}";

        public new bool Equals(object o)
        {
            if (o != null && o is ITask task)
            {
                return Id == task.Id
                && Name == task.Name;
            }

            return false;
        }
    }

    public abstract class TaskBase<T> : TaskBase, ITask<T> where T : IModel
    {
        public new IEnumerable<T> ModuleObjects { get; }

        public new Queue<Func<IEnumerable<IDataItem>, T, ITaskResult<T>>> SubtaskSequence { get; protected set; }


        public TaskBase(string name, Severity severity, IEnumerable<IDataItem> data = null, IEnumerable<T> moduleObjects = null, DateTime? runAt = null) : base(name, severity, data, runAt)
        {
            ModuleObjects = moduleObjects ?? new List<T>();
            SubtaskSequence = new Queue<Func<IEnumerable<IDataItem>, T, ITaskResult<T>>>();
        }

    }
}