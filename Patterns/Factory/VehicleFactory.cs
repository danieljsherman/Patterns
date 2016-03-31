using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.Factory
{
    /// <summary>
    /// Defines an interface for creating an object but lets subclasses decide which class to instantiate
    /// </summary>
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical,
            Midrange,
            Powerful
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColor color)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(color);
            return v;
        }

        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }

    public class CarFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(VehicleFactory.DrivingStyle style)
        {
            switch (style)
            {
                case(DrivingStyle.Economical):
                    return new Sedan(new StandardEngine(1500));
                case(DrivingStyle.Midrange):
                    return new Coupe(new StandardEngine(1650));
                case(DrivingStyle.Powerful):
                    return new Sport(new TurboEngine(2000));
                default:
                    throw new ArgumentOutOfRangeException("style", style, null);
            }
        }
    }

    public class VanFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(VehicleFactory.DrivingStyle style)
        {
            switch (style)
            {
                case DrivingStyle.Economical:
                    return new BoxVan(new StandardEngine(2000));
                case DrivingStyle.Midrange:
                    return new BoxVan(new TurboEngine(2000));
                    break;
                case DrivingStyle.Powerful:
                    return new Pickup(new StandardEngine(2500));
                    break;
                default:
                    throw new ArgumentOutOfRangeException("style", style, null);
            }
        }
    }
}
