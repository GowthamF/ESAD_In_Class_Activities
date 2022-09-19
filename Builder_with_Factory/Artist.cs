using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_with_Factory
{
    public class Artist
    {
        private readonly ShapeBuilder _shapeBuilder;

        public Artist(ShapeBuilder shapeBuilder)
        {
            _shapeBuilder = shapeBuilder;
        }

        public void ConstructShape()
        {
            _shapeBuilder.BuildShape();
            _shapeBuilder.FillColor();
        }

        public IShape GetShape()
        {
            return _shapeBuilder.GetShape();
        }
    }
}
