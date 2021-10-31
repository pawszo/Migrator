using System;

namespace Migrator.ApplicationLayer.Flow
{
    public interface IResult
    {
        string Message { get; }
        DateTime CreatedAt { get; }
        bool IsSuccessful { get; }
    }
}
