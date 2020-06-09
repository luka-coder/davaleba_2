using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array2 = new int[] { 3, 6, 2, 9, 6, 8 };
            Chemi_Klasi_2 obj1 = new Chemi_Klasi_2();
            Chemi_Klasi_1 obj2;
            obj2 = obj1.Gamotana(array2);
            Console.WriteLine($"Min Element of Array: {obj2.min.ToString()}");
            Console.WriteLine($"Max Element of Array: {obj2.max.ToString()}");
            Console.ReadKey();
        }
    }
}
