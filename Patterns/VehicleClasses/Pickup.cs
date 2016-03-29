using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine) : base(engine)
        {
        }

        public Pickup(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
