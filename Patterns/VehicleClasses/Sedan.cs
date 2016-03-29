using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class Sedan : AbstractCar
    {
        public Sedan(IEngine engine) : base(engine)
        {
        }

        public Sedan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
