using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    public class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            //the VanBuilder impliments this method
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}