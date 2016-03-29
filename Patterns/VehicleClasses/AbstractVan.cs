using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine) : base(engine)
        {
        }

        public AbstractVan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
