using Migrator.ApplicationLayer.Enums;

namespace Migrator.ApplicationLayer.Model
{
    public interface ICommonModel : IModel
    {
        long? Id { get; }
        ICommonModelDetail Detail { get; }
    }
}