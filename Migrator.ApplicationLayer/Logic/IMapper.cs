using Migrator.ApplicationLayer.DataAccess;
using Migrator.ApplicationLayer.Model;

namespace Migrator.ApplicationLayer.Logic
{
    public interface IMapper<T> where T : ICommonModel
    {
        D MapToDto<D>(T model) where D : IDto;
        T MapToModel<D>(D dto) where D : IDto;

    }
}
