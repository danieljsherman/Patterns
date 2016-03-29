using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine) : base(engine)
        {
        }

        public Sport(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
