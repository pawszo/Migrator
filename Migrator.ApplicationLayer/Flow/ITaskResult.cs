using Migrator.ApplicationLayer.Logic;
using Migrator.ApplicationLayer.Model;

namespace Migrator.ApplicationLayer.Flow
{
    public interface ITaskResult<T> : IResult where T : IModel
    {
        ITask<T> Task { get; }

    }

    public interface ITaskResult : IResult
    {
        ITask Task { get; }
    }
}
