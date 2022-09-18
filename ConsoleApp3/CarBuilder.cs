using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CarBuilder : VehicleBuilder
    {
        private readonly Car car;

        public CarBuilder()
        {
            car = new Car();
        }


        public override void AddChassy()
        {
            car.Chassy = "Adding Chassy";
            Console.WriteLine(car.Chassy);
        }

        public override void AddEngine()
        {
            car.Engine = "Adding Engine";
            Console.WriteLine(car.Engine);
        }

        public override void AddOuterFramework()
        {
            car.OuterFramework = "Adding OuterFramework";
            Console.WriteLine(car.OuterFramework);
        }

        public override void AddTyres()
        {
            car.Tyres = "Adding Tyres";
            Console.WriteLine(car.Tyres);
        }

        public override IVehicle GetVehicle()
        {
            Console.WriteLine("Returning the Car");
            return car;
        }
    }
}
