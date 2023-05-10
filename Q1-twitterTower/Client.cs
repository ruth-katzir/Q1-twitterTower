using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Creators;

namespace FactoryPattern
{
    class Client
    {
        public void Main(int tower)
        {
            ShapeFactory factory = ShapeFactory.Instance;

            ClientCode(factory.CreateNewShape(tower));
        }

        public void ClientCode(ShapeFactory creator)
        {
            Console.WriteLine("enter tower width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("enter tower height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(creator ? .SomeOperation(width,height) ?? "No shape");
        }
    }
}
