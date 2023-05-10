using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Shapes;
namespace FactoryPattern.Creators
{
    class TriangleCreator : ShapeFactory
    {
        public override Shape FactoryMethod(int width, int height)
        {
            return new Triangle(width,height);
        }
    }
}
