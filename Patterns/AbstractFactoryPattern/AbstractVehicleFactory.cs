using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.AbstractFactoryPattern
{
    /// <summary>
    /// The Abstract Factory Pattern provides and interface for creating families of related or dependent
    /// objects without specifying their concreate classes.
    /// Factory classes inherit from AbstractVehicleFactory and consuming classes work with AbstractVehicleFactory
    /// rather than the concrete classes themselves.
    /// </summary>
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }
}
