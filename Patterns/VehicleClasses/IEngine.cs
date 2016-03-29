using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }
    }
}
