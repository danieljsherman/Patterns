using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.VehicleClasses
{
    public class VanBody : IBody
    {
        public virtual string BodyParts
        {
            get { return "Body shell parts for a van."; }
        }
    }
}
