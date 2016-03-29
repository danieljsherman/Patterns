using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine) : base(engine)
        {
        }

        public BoxVan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
