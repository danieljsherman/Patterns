using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{

    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColor Color { get; }
        void Paint(VehicleColor color);
    }
}
