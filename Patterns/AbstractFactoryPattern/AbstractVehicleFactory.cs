using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.AbstractFactoryPattern
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }
}
