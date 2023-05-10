using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Shapes
{
    class Triangle : Shape
    {

        public Triangle(int width, int height)
        {
            Console.WriteLine("triangle tower builed");
            this.width = width;
            this.height = height;
        }
        public string printTheTriangle()
        {
            StringBuilder sb = new StringBuilder();

            //חישוב מס' קבוצות
            int numOfGroups = (this.width - 2) / 2;
            int numOfReturn = (this.height - 2) / numOfGroups;
            int sherit = (this.height - 2) % numOfGroups;
            int spaces = (this.height - 2)/2;
            for (int i = 1; i <= this.width; i += 2)
            {
                int multRow = 0;
                switch (i)
                {
                    case var _ when i == this.width || i==1:
                        multRow = 1; break;
                    case 3:
                        multRow = numOfReturn + sherit; break;
                    default:
                        multRow = numOfReturn;
                        break;
                }

                for (int j = 0; j < multRow; j++)
                {
                    sb.AppendLine($"{new string(' ', spaces)}{new string('*', i)}");
                }
                spaces--;
            }
            return sb.ToString();
        }
        public override string printTower()
        {
            Console.WriteLine("you have 2 options below, you may choose only one- to see the triangle perimeter or print:");
            Console.WriteLine("do you want to see the triangle perimeter?");
            string printPerimeter = Console.ReadLine();
            if (printPerimeter == "yes")
            {
                // Calculate half the base
                int halfBase = this.width / 2;

                // Calculate the length of the hypotenuse (i.e., the side of the isosceles triangle)
                double hypotenuse = Math.Sqrt(halfBase * halfBase + this.height * height);

                // Calculate the length of the other two sides
                double sideLength = 2 * hypotenuse;

                double trianglePerimeter = this.width + sideLength;
                return ($"the triangle perimeter is: {trianglePerimeter}");
            }
            Console.WriteLine("do you want to see the triangle print?");
            string printTriangle = Console.ReadLine();
            if (printTriangle == "yes")
            {
                if (this.width % 2 == 0 || this.width > 2 * this.height)
                {
                    return "that triangle is not able to print";
                }
                else
                {
                    return printTheTriangle();
                }
            }
            return ""; ;

        }

    }
}
