using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public abstract class AbstractEngine : IEngine
    {
        private int _size;
        private bool _turbo;

        public AbstractEngine(int size, bool turbo)
        {
            _size = size;
            _turbo = turbo;
        }

        //explicit getters because we want to try out aspect oriented programming for logging
        public int Size { get { return _size; } }
        public bool Turbo { get { return _turbo; } }

        public override string ToString()
        {
            return GetType().Name + " (" + _size + ")";
        }
    }
}
