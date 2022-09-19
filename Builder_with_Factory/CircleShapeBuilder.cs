using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_with_Factory
{
    public class CircleShapeBuilder : ShapeBuilder
    {
        private readonly IShape circleShape;

        public CircleShapeBuilder()
        {
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");

            circleShape = (IShape)shapeFactory.GetAbstractFactory("circle");
        }

        public override void BuildShape()
        {
            circleShape.Draw();
        }

        public override void FillColor()
        {
            var colorFactory = FactoryProducer.GetFactory("COLOR");

            IColor redColor = (IColor)colorFactory.GetAbstractFactory("red");
            redColor.Fill();
        }

        public override IShape GetShape()
        {
            return circleShape;
        }
    }
}
