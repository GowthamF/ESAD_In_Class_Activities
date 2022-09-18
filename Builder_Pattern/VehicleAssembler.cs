using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class VehicleAssembler
    {
        private readonly VehicleBuilder _vehicleBuilder;

        public VehicleAssembler(VehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public void AssembleVehicle()
        {
            _vehicleBuilder.AddTyres();
            _vehicleBuilder.AddEngine();
            _vehicleBuilder.AddChassy();
            _vehicleBuilder.AddOuterFramework();
        }

        public IVehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
