using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternsUI.Exceptions
{
    public class ModelNotCreatedException : Exception
    {
        public ModelNotCreatedException() : base("Could not create Model.")
        {
        }
    }
}
