namespace Patterns.VehicleClasses
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get { return "Chassis parts for a van."; }
        }
    }
}