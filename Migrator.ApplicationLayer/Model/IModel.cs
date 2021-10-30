using Migrator.ApplicationLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Model
{
    public interface IModel
    {
        int Id { get; }
        string Symbol { get; }
        string Name { get; set; }
        IDictionary<string, IParameter> Parameters { get; }

    }
}
