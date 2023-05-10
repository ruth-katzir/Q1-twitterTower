using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Shapes
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    abstract class Shape
    {
        public int height { get; set; }

        public int width { get; set; }
        public abstract string printTower();
    }
}
