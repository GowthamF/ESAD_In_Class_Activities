using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_with_Factory
{
    public class RectangleBuilder : ShapeBuilder
    {

        private readonly IShape recatangleShape;

        public RectangleBuilder()
        {
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");
            
            recatangleShape = (IShape)shapeFactory.GetAbstractFactory("rectangle");
        }

        public override void BuildShape()
        {
            recatangleShape.Draw();
        }

        public override void FillColor()
        {
            var colorFactory = FactoryProducer.GetFactory("COLOR");

            IColor redColor = (IColor)colorFactory.GetAbstractFactory("red");
            redColor.Fill();
        }

        public override IShape GetShape()
        {
            return recatangleShape;
        }
    }
}
