using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class VehicleBuilder
    {
        
        public abstract void AddTyres();
        public abstract void AddEngine();
        public abstract void AddChassy();
        public abstract void AddOuterFramework();
        public abstract IVehicle GetVehicle();
    }
}
