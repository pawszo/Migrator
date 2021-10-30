using Migrator.ApplicationLayer.DataAccess;

namespace Migrator.ApplicationLayer.Logic
{
    public interface IMapper<T>
    {
        D MapToDto<D>(T model) where D : IDto;
        T MapToModel<D>(D dto) where D : IDto;
        P ConvertParameter<P>(P parameter) where P : IParameter;

    }
}
