using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Flow
{
    public interface IActionResult : IResult
    {
        bool IsSuccessful { get; }
        object Response { get; }
    }
}
