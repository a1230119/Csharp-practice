using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4._1___Tower_of_Hanoi
{
    class Program
    {
        private static void Hanoi(int layer, char x, char y, char z)
        {
            if (layer == 1)
                Console.WriteLine("Move sheet from {0} to {1}", x, z);
            else
            {
                Hanoi(layer - 1, x, z, y);
                Console.WriteLine("Move sheet from {0} to {1}", x, z);
                Hanoi(layer - 1, y, x, z);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入盤數 : ");
            int layer = int.Parse(Console.ReadLine());
            Hanoi(layer, 'A', 'B', 'C');
            Console.Read();
        }
    }
}
