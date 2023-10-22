using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x, y;
            Console.Write("Enter the size of the '0': ");
            num = Convert.ToInt32(Console.ReadLine());

            for (y = 1; y <= num * 2 - 1; y++)
            {
                for (x = 1; x <= num * 2 - 1; x++)
                {
                    int dX = (x - num);
                    int dY = (y - num);

                    if (Math.Sqrt(dX * dX + dY * dY) <= num - 0.5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }




    }
}
