using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car : IVehicle
    {
        public string Tyres
        {
            get; set;
        }

        public string Engine
        {
            get; set;
        }

        public string Chassy
        {
            get; set;
        }

        public string OuterFramework
        {
            get; set;
        }
    }
}
