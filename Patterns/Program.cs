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

            Console.WriteLine("************* Implimenting Abstract Factory Pattern. ********\n");
            Console.Write("Enter the vehicle you want (car/van): ");
            string _whatToMake = Console.ReadLine();
            
            AbstractVehicleFactory factory;

            switch (_whatToMake)
            {
                case("car"):
                    Console.WriteLine("\nCreating a CarFactory.\n");
                    factory = new CarFactory();
                    break;
                case("van"):
                    Console.WriteLine("\nCreating a VanFactory.\n");
                    factory = new VanFactory();
                    break;
                default:
                    throw new Exception("\n" + _whatToMake + "is not supported\n");
            }

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);
            Console.WriteLine("\n********** End Abstract Factory Pattern ************\n");
            Console.Read();
        }
    }
}
