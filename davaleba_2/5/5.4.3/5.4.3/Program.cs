using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Masivi m = new Masivi();
            int[] array = new int[] { 5, 2, -3, 6, -1, 9, -8 };
            int Shedegi = m.Gamotvla(array);
            Console.WriteLine($"First negative Element is : {Shedegi}");
            Console.ReadKey();
        }
    }
}
