using Migrator.ApplicationLayer.Enums;

namespace Migrator.ApplicationLayer.Model
{
    public interface IModule : IModel
    {
        ModuleObject ModuleClass { get; }

        
    }
}
