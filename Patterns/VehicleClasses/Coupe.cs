using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine) : base(engine)
        {
        }

        public Coupe(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
