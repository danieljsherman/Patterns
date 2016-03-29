using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar _carInProgress;

        public CarBuilder(AbstractCar car)
        {
            _carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Car Body.");
        }

        public override void BuildStorage()
        {
            Console.WriteLine("Building Car Trunk.");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building Car Chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building Car Passenger Area.");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building Car Windows.");
        }

        public override IVehicle Vehicle
        {
            get { return _carInProgress; }
        }
    }
}
