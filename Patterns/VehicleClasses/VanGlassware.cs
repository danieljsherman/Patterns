namespace Patterns.VehicleClasses
{
    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Glassware parts for a van."; }
        }
    }
}