using Patterns.VehicleClasses;

namespace Patterns.Builder
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            //the CarBuilder impliments this method
            builder.BuildStorage();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}