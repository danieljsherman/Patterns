using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine _engine;
        private VehicleColor _color;

        public AbstractVehicle(IEngine engine) : this(engine,VehicleColor.Unpainted)
        {
        }

        public AbstractVehicle(IEngine engine, VehicleColor color)
        {
            _engine = engine;
            _color = color;
        }

        #region IVehicle Members

        public IEngine Engine
        {
            get { return _engine; }
        }

        public VehicleColor Color
        {
            get { return _color; }
        }

        public void Paint(VehicleColor color)
        {
            _color = color;
        }

        #endregion

        public override string ToString()
        {
            return GetType().Name + " (" + _engine + ", " + _color + ")";
        }
    }
}
