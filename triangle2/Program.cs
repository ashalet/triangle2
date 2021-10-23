using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string katetA = Console.ReadLine();
            string katetB = Console.ReadLine();
            int lenA = 0;

            int a = int.Parse(katetA);
            int b = int.Parse(katetB);
            int c = b;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("" +
                    "");
            }
            Console.ReadLine();
        }
    }
}
