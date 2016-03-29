using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    /// <summary>
    /// The Builder pattern is used to separate the construction of a complex object from its representation
    /// so that the same construction process can create different representations.
    /// </summary>
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody()
        {
        }

        public virtual void BuildStorage()
        {
        }

        public virtual void BuildChassis()
        {
        }

        public virtual void BuildPassengerArea()
        {
        }

        public virtual void BuildReinforcedStorageArea()
        {
        }

        public virtual void BuildWindows()
        {
        }

        public abstract IVehicle Vehicle { get; }
    }
}
