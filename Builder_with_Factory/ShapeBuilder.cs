using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_with_Factory
{
    public  abstract class ShapeBuilder
    {
        public abstract void BuildShape();

        public abstract void FillColor();

        public abstract IShape GetShape();

    }
}
