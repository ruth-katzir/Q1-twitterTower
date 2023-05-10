using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int towerType = 0;
            while(towerType != 3)
            {
                Console.WriteLine("enter 1 to create triangle, 2 to create rectangle, 3 to exit");
                towerType=int.Parse(Console.ReadLine());
                if(towerType == 1 || towerType == 2) { new Client().Main(towerType); }
            }  
        }
    }
}
