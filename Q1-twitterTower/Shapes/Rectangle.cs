using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Console.WriteLine("rectangle tower builed");
            this.width = width;
            this.height = height;
        }
        public override string printTower()
        {
            if(Math.Abs(this.width-this.height)>5)
            {
                int area= this.width*this.height;
                return "the rectangle area is: "+ area;
            }
            else
            {
                int perimeter= 2*this.width+2*this.height;
                return "the rectangle perimeter is: "+ perimeter;
            }
            
        }
    }
}
