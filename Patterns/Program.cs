using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactoryPattern;
using Patterns.VehicleClasses;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string _whatToMake = "car";
            AbstractVehicleFactory factory;

            switch (_whatToMake)
            {
                case("car"):
                    factory = new CarFactory();
                    break;
                case("van"):
                    factory = new VanFactory();
                    break;
                default:
                    throw new Exception("Type not supported");
            }

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);

            Console.Read();
        }
    }
}
