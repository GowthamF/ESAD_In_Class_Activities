using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BusBuilder : VehicleBuilder
    {
        private readonly Bus bus;

        public BusBuilder()
        {
            bus = new Bus();
        }


        public override void AddChassy()
        {
            bus.Chassy = "Adding Chassy";
            Console.WriteLine(bus.Chassy);
        }

        public override void AddEngine()
        {
            bus.Engine = "Adding Engine";
            Console.WriteLine(bus.Engine);
        }

        public override void AddOuterFramework()
        {
            bus.OuterFramework = "Adding OuterFramework";
            Console.WriteLine(bus.OuterFramework);
        }

        public override void AddTyres()
        {
            bus.Tyres = "Adding Tyres";
            Console.WriteLine(bus.Tyres);
        }

        public override IVehicle GetVehicle()
        {
            Console.WriteLine("Returning the Bus");
            return bus;
        }
    }
}
