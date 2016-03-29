using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : base(engine)
        {
        }

        public AbstractCar(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
