using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Shapes;

namespace FactoryPattern.Creators
{
    class ShapeFactory
    {
        protected ShapeFactory() { }
        public static ShapeFactory Instance { get; }
        static ShapeFactory() => Instance = new ShapeFactory();
        public virtual Shape FactoryMethod(int width, int height)=> new Rectangle(width, height);

        public ShapeFactory CreateNewShape(int shapeType)
        {
            return shapeType == 1 ? new TriangleCreator() :
                    shapeType == 2 ? new RectangleCreator() :
                    null;
        }
        public string SomeOperation(int width, int height)
        {
            var shape = FactoryMethod(width, height);
           
            return shape.printTower();
        }
    }
}
