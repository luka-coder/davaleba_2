using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Printing 10 random numbers less than 100");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} -> {1}", i, rand.Next(100));
            }
            Console.ReadKey();
        }
    }
}
