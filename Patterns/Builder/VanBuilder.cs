using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractVan _vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            _vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Van Body.");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("Building Van Storage Area.");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building Van Chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building Van Passenger Area.");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building Van Windows.");
        }

        public override IVehicle Vehicle
        {
            get { return _vanInProgress; }
        }
    }
}
