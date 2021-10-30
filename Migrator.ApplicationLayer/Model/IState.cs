using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.ApplicationLayer.Model
{
    public interface IState
    {
        bool Enabled { get; set; }
    }
}
