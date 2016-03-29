using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    /// <summary>
    /// Director classes take in a builder object and call the appropriate builder methods on it and return
    /// the built object.
    /// </summary>
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
