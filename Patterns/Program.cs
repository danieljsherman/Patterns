using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactoryPattern;
using Patterns.Builder;
using Patterns.Factory;
using Patterns.VehicleClasses;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //MakeAbstractFactory();
            //MakeBuilder();
            MakeFactory();
            Console.Read();
        }

        public static void PrintHeader(string header)
        {
            Console.WriteLine("\n********** Implimenting " + header + "Pattern. ***********\n");
        }

        public static void PrintFooter(string footer)
        {
            Console.WriteLine("\n********** Implimenting " + footer + "Pattern. ***********\n");
        }

        public static void MakeAbstractFactory()
        {
            PrintHeader("Abstract Factory");
            
            Console.Write("Enter the vehicle you want (car/van): ");
            string _whatToMake = Console.ReadLine();

            //instantiate an AbstractVehicleFactory since we want to always use the abstract class or interface.
            //Plus, we don't know what type of factory we're creating yet.
            AbstractVehicleFactory factory;

            switch (_whatToMake)
            {
                case ("car"):
                    Console.WriteLine("\nCreating a CarFactory.\n");
                    factory = new AbstractFactoryPattern.CarFactory();
                    break;
                case ("van"):
                    Console.WriteLine("\nCreating a VanFactory.\n");
                    factory = new AbstractFactoryPattern.VanFactory();
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

            PrintFooter("Abstract Factory");
        }

        public static void MakeBuilder()
        {
            PrintHeader("Builder");
            
            //Notice how we are instantiating the abstract classes rather than the concrete classes
            AbstractCar car = new Sedan(new StandardEngine(1500));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle vehicle = director.Build(builder);
            
            Console.WriteLine("\n" + vehicle);
            PrintFooter("Builder");
        }

        public static void MakeFactory()
        {
            PrintHeader("Factory");

            //Make an economical green car
            VehicleFactory carFactory = new Factory.CarFactory();
            IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColor.Green);
            Console.WriteLine(car + "\n");

            //Make my truck
            VehicleFactory vanFactory = new Factory.VanFactory();
            IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColor.Red);
            Console.WriteLine(van + "\n");
            PrintFooter("Factory");
        }
    }
}
